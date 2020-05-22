using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Xml;
using WebShop.Bll.DTO;
using WebShop.Bll.Exceptions;
using WebShop.Bll.Extensions;
using WebShop.Bll.ServiceInterfaces;
using WebShop.Bll.Specifications;
using WebShop.Dal.Context;
using WebShop.Dal.Enums;
using WebShop.Dal.Models;
using WebShop.Dal.Models.Users;

namespace WebShop.Bll.Services
{
    public static class ListShuffleHelper
    {
        private static Random rng = new Random();

        public static void Shuffle<T>(this IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }

    public class ItemService : IItemService
    {
        private readonly WebShopDbContext context;

        public ItemService(WebShopDbContext dbContext)
        {
            this.context = dbContext;
        }


        public static Expression<Func<Item, ItemHeader>> ItemHeaderSelector { get; } = x => new ItemHeader(x);

        public static Lazy<Func<Item, ItemHeader>> ItemHeaderSelectorFunc { get; } = new Lazy<Func<Item, ItemHeader>>(() => ItemHeaderSelector.Compile());

        public PagedResult<ItemHeader> GetAllItems(ItemSpecification specification = null)
        {
            if (specification == null)
                specification = new ItemSpecification();

            if (specification.PageSize < 0)
                specification.PageSize = null;
            if (specification.PageNumber < 0)
                specification.PageNumber = null;

            IQueryable<Item> query = this.context.Items
                .Include(x => x.Ratings);

            if (!string.IsNullOrWhiteSpace(specification.ComplexFilter))
            {
                query = query.Where(x => x.Name.Contains(specification.ComplexFilter) ||
                                 x.Manufacturer.Contains(specification.ComplexFilter) ||
                                 x.ShortDescription.Contains(specification.ComplexFilter));
            }

            if (!string.IsNullOrWhiteSpace(specification.Name))
                query = query.Where(x => x.Name.Contains(specification.Name));

            if (specification.SelectedCategories.Any())
            {
                var selectedCategoriesEnum = new List<Category>();
                specification.SelectedCategories.ForEach(x =>
           {
               selectedCategoriesEnum.Add(EnumExtensionMethods.GetValueFromDescription<Category>(x));
           });
                query = query.Where(x => selectedCategoriesEnum.Contains(x.Category));
            }

            if (specification.SelectedManufacturers.Any())
                query = query.Where(x => specification.SelectedManufacturers.Contains(x.Manufacturer));

            if (specification.HasRGB.HasValue)
                query = query.Where(x => x.HasRGB == specification.HasRGB);

            if (specification.IsNewArrival.HasValue)
                query = query.Where(x => x.DateSinceInStore > DateTime.Now.AddDays(-30));

            if (specification.IsDiscounted.HasValue)
                query = query.Where(x => x.DiscountedPrice != null && x.DiscountedPrice < x.OriginalPrice);

            if (specification.IsGaming.HasValue)
                query = query.Where(x => x.GamingFlag == specification.IsGaming);

            if (specification.IsUsed.HasValue)
                query = query.Where(x => x.IsUsed == specification.IsUsed);

            if (specification.MinPrice != null)
                query = query.Where(x => (x.DiscountedPrice ?? x.OriginalPrice) >= specification.MinPrice);

            if (specification.MaxPrice != null)
                query = query.Where(x => (x.DiscountedPrice ?? x.OriginalPrice) <= specification.MaxPrice);

            if (specification.MinRating != null)
                query = query.Where(x => (x.Ratings.Any() ? Convert.ToInt32(x.Ratings.Average(y => y.Value)) : 0) >= specification.MinRating);

            if (specification.MaxRating != null)
                query = query.Where(x => (x.Ratings.Any() ? Convert.ToInt32(x.Ratings.Average(y => y.Value)) : 0) <= specification.MaxRating);

            //order
            switch (specification.Order)
            {
                case ItemSpecification.ItemOrder.PriceAscending:
                    query = query.OrderBy(x => x.DiscountedPrice ?? x.OriginalPrice);
                    break;

                case ItemSpecification.ItemOrder.PriceDescending:
                    query = query.OrderByDescending(x => x.DiscountedPrice ?? x.OriginalPrice);
                    break;

                case ItemSpecification.ItemOrder.RatingAscending:
                    query = query.OrderBy(x => (x.Ratings.Any() ? Convert.ToInt32(x.Ratings.Average(y => y.Value)) : 0));
                    break;

                case ItemSpecification.ItemOrder.RatingDescending:
                    query = query.OrderByDescending(x => (x.Ratings.Any() ? Convert.ToInt32(x.Ratings.Average(y => y.Value)) : 0));
                    break;
            }

            int? allResultsCount = null;
            if ((specification.PageSize ?? 0) != 0)
            {
                specification.PageNumber ??= 0;
                allResultsCount = query.Count();
                query = query
                    .Skip(specification.PageNumber.Value * specification.PageSize.Value)
                    .Take(specification.PageSize.Value);
            }

            int totalMaxPrice, totalMinPrice;
            var maxDiscounted = context.Items.Max(x => x.DiscountedPrice);
            var maxOriginal = context.Items.Max(x => x.OriginalPrice);
            var minDiscounted = context.Items.Min(x => x.DiscountedPrice);
            var minOriginal = context.Items.Min(x => x.OriginalPrice);
            if (maxDiscounted != null)
            {
                totalMaxPrice = maxOriginal > maxDiscounted ? maxOriginal : maxDiscounted.Value;
                totalMinPrice = maxOriginal > maxDiscounted ? minOriginal : minDiscounted.Value;
            }
            else
            {
                totalMaxPrice = maxOriginal;
                totalMinPrice = minOriginal;
            }

            return new PagedResult<ItemHeader>
            {
                AllResultsCount = allResultsCount,
                Results = query.ToList().Select(ItemHeaderSelectorFunc.Value),
                Categories = context.Items.Select(x => EnumExtensionMethods.GetDescription(x.Category)).Distinct().ToList(),
                Manufacturers = context.Items.Select(x => x.Manufacturer).Distinct().ToList(),
                TotalMaxPrice = totalMaxPrice,
                TotalMinPrice = totalMinPrice,
                PageNumber = specification.PageNumber,
                PageSize = specification.PageSize,
                Specification = specification,
            };
        }



        public ItemFullViewDTO GetItemById(Guid id)
        {
            var similarItems = new List<ItemHeader>();

            var returnDto = new ItemFullViewDTO(this.context.Items
                .Include(x => x.Ratings)
                .Include(x => x.Comments).ThenInclude(c => c.User)
                .SingleOrDefault(x => x.Id == id));

            var temp = this.context.Items.Where(x => x.Category == EnumExtensionMethods.GetValueFromDescription<Category>(returnDto.Category)).Include(x => x.Ratings).Include(x => x.Comments).ToList();
            temp.ForEach(x =>
           {
               if (x.Id != id)
               {
                   similarItems.Add(new ItemHeader(x));
               }
           });

            returnDto.SimilarItems = new PagedResult<ItemHeader>
            {
                AllResultsCount = similarItems.Count <= 3 ? similarItems.Count : 3,
                Results = similarItems.Count <= 3 ? similarItems : similarItems.Take(3).ToList(),
                PageNumber = 0,
                PageSize = 1
            };

            return returnDto;
        }

        public List<ItemHeader> GetAllDiscountedItems()
        {
            var items = this.context.Items.Include(x => x.Ratings).Where(x => x.DiscountedPrice! != null && x.DiscountedPrice <= (x.OriginalPrice * 0.75)).ToList();
            items.Shuffle();
            if (items.Count() >= 5)
            {
                items = items.Take(5).ToList();
            }

            var itemHeaders = new List<ItemHeader>();
            items.ForEach(x =>
           {
               itemHeaders.Add(new ItemHeader(x));
           });


            return itemHeaders;
        }

        public List<ItemHeader> GetAllHighLightedItems()
        {
            var items = this.context.Items.Include(x => x.Ratings).Where(x => x.HighlightedItem).ToList();
            if (items.Count() >= 3)
            {
                items.Shuffle();
                items = items.Take(3).ToList();
            }

            var itemHeaders = new List<ItemHeader>();
            items.ForEach(x =>
            {
                itemHeaders.Add(new ItemHeader(x));
            });


            return itemHeaders;
        }



        public void AddComment(Guid userId, Guid itemId, string content, int? rating, DateTime date)
        {
            var User = this.context.Users.SingleOrDefault(u => u.Id == userId);
            if (User == null)
            {
                throw new UserNotFoundException("There is no user in the database with the given ID");
            }
            var item = this.context.Items.SingleOrDefault(x => x.Id == itemId);
            if (item == null)
            {
                throw new ItemNotFoundException("There is no item in the database with the given ID");
            }

            this.context.Comments.Add(new Comment()
            {
                ItemId = itemId,
                UserId = userId,
                CommentText = content,
                Date = date
            });
            if (rating != null)
            {
                //given user has already rated the item
                if (context.Ratings.SingleOrDefault(x => x.UserId == userId && x.ItemId == itemId) != null)
                {
                    var alreadyExistingRating = context.Ratings.SingleOrDefault(x => x.UserId == userId && x.ItemId == itemId);
                    alreadyExistingRating.Value = rating.Value;
                }
                else
                {
                    this.context.Ratings.Add(new Rating
                    {
                        ItemId = itemId,
                        UserId = userId,
                        Value = rating.Value
                    });
                }
            }

            this.context.SaveChanges();

        }

        public List<ItemHeader> GetAvailableItems()
        {
            var items = this.context.Items.Include(x => x.Ratings).Where(x => x.Available > 0).ToList();
            var itemHeaders = new List<ItemHeader>();
            items.ForEach(x =>
            {
                itemHeaders.Add(new ItemHeader(x));
            });

            return itemHeaders;
        }

        public void CreateItem(CreateItemDTO item)
        {
            switch (EnumExtensionMethods.GetValueFromDescription<Category>(item.Category))
            {
                case Category.Cpu:
                    {
                        var cpu = new Cpu()
                        {
                            Name = item.Name,
                            Category = Category.Cpu,
                            Available = 20,
                            PicturePath = item.PicturePath,
                            OriginalPrice = item.OriginalPrice,
                            DiscountedPrice = item.DiscountedPrice,
                            Manufacturer = item.Manufacturer,
                            ShortDescription = item.ShortDescription,
                            Description = item.Description,
                            Warranty = item.Warranty,
                            GamingFlag = item.GamingFlag,
                            IsUsed = item.IsUsed,
                            HasRGB = item.HasRGB,
                            DateSinceInStore = DateTime.Now,

                            BaseClock = item.BaseClock.Value,
                            TDP = item.TDP.Value,
                            ProcessorFamily = item.ProcessorFamily,
                            Technology = item.Technology == null ? 0 : item.Technology.Value,
                            CoreNumber = item.CoreNumber == null ? 0 : item.CoreNumber.Value,
                            ThreadNumber = item.ThreadNumber == null ? 0 : item.ThreadNumber.Value,
                            Socket = item.Socket
                        };

                        this.context.Items.Add(cpu);
                        break;
                    }
                case Category.Case:
                    {
                        var pcCase = new Case()
                        {
                            Name = item.Name,
                            Category = Category.Cpu,
                            Available = 20,
                            PicturePath = item.PicturePath,
                            OriginalPrice = item.OriginalPrice,
                            DiscountedPrice = item.DiscountedPrice,
                            Manufacturer = item.Manufacturer,
                            ShortDescription = item.ShortDescription,
                            Description = item.Description,
                            Warranty = item.Warranty,
                            GamingFlag = item.GamingFlag,
                            IsUsed = item.IsUsed,
                            HasRGB = item.HasRGB,
                            DateSinceInStore = DateTime.Now,

                            BuiltInFanNumber = item.BuiltInFanNumber == null ? 0 : item.BuiltInFanNumber.Value,
                            SupportedMotherboard = item.SupportedMotherboard,
                            Height = item.Height == null ? 0 : item.Height.Value,
                            Width = item.Width == null ? 0 : item.Width.Value,
                            Depth = item.Depth == null ? 0 : item.Depth.Value,
                            HDDNumber = item.HDDNumber == null ? 0 : item.HDDNumber.Value,
                        };

                        this.context.Items.Add(pcCase);
                        break;
                    }
                    //TODO: case for all types
            }
            context.SaveChanges();
        }

        public void EditItem(EditItemDTO item)
        {
            var itemDbModel = this.context.Items.SingleOrDefault(x => x.Id.ToString() == item.Id);
            foreach (var prop in item.GetType().GetProperties())
            {
                if (prop.GetValue(item, null) != null && prop.Name != "Id")
                {
                    if (itemDbModel.GetType().GetProperties().SingleOrDefault(x => x.Name == prop.Name) != null)
                    {
                        var propertyToModify = itemDbModel.GetType().GetProperties().SingleOrDefault(x => x.Name == prop.Name);
                        propertyToModify.SetValue(itemDbModel, prop.GetValue(item, null));
                    }
                }
            }

            this.context.SaveChanges();

        }

        public void ChangeAvailability(string id, int value)
        {
            var item = this.context.Items.SingleOrDefault(x => x.Id.ToString() == id);
            if (item == null)
                throw new ItemNotFoundException("Item with the given id was not found");

            if(value >= 0  && value != item.Available)
            {
                if(item.Available == 0)
                {

                }
                item.Available = value;

                context.SaveChanges();
            }
        }
    }
}
