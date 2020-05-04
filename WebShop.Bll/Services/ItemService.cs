using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using WebShop.Bll.DTO;
using WebShop.Bll.ServiceInterfaces;
using WebShop.Bll.Specifications;
using WebShop.Dal.Context;
using WebShop.Dal.Models;

namespace WebShop.Bll.Services
{
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

            if (!string.IsNullOrWhiteSpace(specification.Name))
                query = query.Where(x => x.Name.Contains(specification.Name));

            if (specification.Category.HasValue)
                query = query.Where(x => x.Category == specification.Category);

            if (!string.IsNullOrWhiteSpace(specification.Brand))
                query = query.Where(x => x.Manufacturer.Contains(specification.Brand));

            if (specification.HasRGB.HasValue)
                query = query.Where(x => x.HasRGB == specification.HasRGB);

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
            switch(specification.Order)
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

            return new PagedResult<ItemHeader>
            {
                AllResultsCount = allResultsCount,
                Results = query.ToList().Select(ItemHeaderSelectorFunc.Value),
                PageNumber = specification.PageNumber,
                PageSize = specification.PageSize
            };
        }



        public ItemFullViewDTO GetItemById(Guid id)
        {
            var similarItems = new List<ItemHeader>();

            var returnDto= new ItemFullViewDTO(this.context.Items
                .Include(x => x.Ratings)
                .SingleOrDefault(x => x.Id == id));

            var temp = this.context.Items.Where(x => x.Category == returnDto.Category).Include( x => x.Ratings).ToList();
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

    }
}
