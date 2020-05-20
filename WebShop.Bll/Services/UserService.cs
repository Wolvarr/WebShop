using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using WebShop.Bll.DTO;
using WebShop.Bll.Exceptions;
using WebShop.Bll.Extensions;
using WebShop.Bll.ServiceInterfaces;
using WebShop.Dal.Context;
using WebShop.Dal.Models;
using WebShop.Dal.Models.Users;

namespace WebShop.Bll.Services
{
    public class UserService : IUserService
    {
        private readonly WebShopDbContext context;

        public UserService(Dal.Context.WebShopDbContext dbContext)
        {
            this.context = dbContext;
        }

        public bool SubscriebeToNotification(Guid userId, Guid itemId)
        {
            if (this.context.UserSubscriptions.SingleOrDefault(x => x.UserId == userId && x.ItemId == itemId) != null)
            {
                return false;
            }

            var User = this.context.Users.SingleOrDefault(u => u.Id == userId);
            var Item = this.context.Items.SingleOrDefault(u => u.Id == itemId);

            this.context.UserSubscriptions.Add(new UserSubscription(User, Item));
            this.context.SaveChanges();
            return true;
        }

        public List<ItemForShoppingCartDTO> GetAllItemsInCart(Guid userId)
        {
            var User = this.context.Users.SingleOrDefault(u => u.Id == userId);
            if (User == null)
            {
                throw new UserNotFoundException("There is no user in the database with the given ID");
            }

            var listToReturn = new List<ItemForShoppingCartDTO>();
            var itemList = this.context.UserCartItems.Where(x => x.UserId == userId).ToList();

            itemList.ForEach(x =>
            {
                listToReturn.Add(new ItemForShoppingCartDTO(this.context.Items.SingleOrDefault(i => i.Id == x.ItemId), x.Quantity));
            });

            return listToReturn;
        }

        public void RemoveItemFromCart(Guid userId, Guid itemId)
        {
            var User = this.context.Users.SingleOrDefault(u => u.Id == userId);
            if (User == null)
            {
                throw new UserNotFoundException("There is no user in the database with the given ID");
            }

            var itemToRemove = this.context.UserCartItems.SingleOrDefault(x => x.UserId == x.UserId && x.ItemId == itemId);
            this.context.UserCartItems.Remove(itemToRemove);
            this.context.SaveChanges();
        }


        public void EditCartItemQuantity(Guid userId, Guid cartItemId, int quantity)
        {
            if (this.context.UserCartItems.SingleOrDefault(x => x.ItemId == cartItemId && x.UserId == userId) == default)
            {
                throw new UserNotFoundException("This cart item does not belong to this user, or does not exist");
            }

            var itemToModify = this.context.UserCartItems.SingleOrDefault(x => x.ItemId == cartItemId);
            itemToModify.Quantity = quantity;
            this.context.SaveChanges();
        }

        public void CreateOrder(CreateOrderDTO orderDto)
        {
            var items = new List<OrderItem>();
            var user = this.context.Users.Include(x => x.CartItems).SingleOrDefault(x => x.Id == orderDto.UserId);
            user.CartItems.ForEach(x =>
            {
                items.Add(new OrderItem() { ItemId = x.ItemId });
            });

            if (orderDto.BillingAddres.Country == null)
                orderDto.BillingAddres.Country = orderDto.ShippingAddres.Country;

            if (orderDto.BillingAddres.ZipCode == null)
                orderDto.BillingAddres.ZipCode = orderDto.ShippingAddres.ZipCode;

            if (orderDto.BillingAddres.Street == null)
                orderDto.BillingAddres.Street = orderDto.ShippingAddres.Street;

            if (orderDto.BillingAddres.HouseNumberAndDoor == null)
                orderDto.BillingAddres.HouseNumberAndDoor = orderDto.ShippingAddres.HouseNumberAndDoor;

            var order = new Order()
            {
                UserId = orderDto.UserId,
                OrderStatus = Dal.Enums.OrderStatus.New,
                PaymentMethod = EnumExtensionMethods.GetValueFromDescription<PaymentMethod>(orderDto.PaymentMethod),
                Items = items,
                BillingAddress = orderDto.BillingAddres,
                ShippingAddress = orderDto.ShippingAddres,
                OrderDate = DateTime.Now,
                DeliveryDate = null,
                Comment = orderDto.Comment
            };
            this.context.Orders.Add(order);
            this.context.SaveChanges();

            order.Items.ForEach(x => x.OrderId = order.Id);
            user.CartItems.ForEach(x =>
            {
                context.UserCartItems.Remove(x);
            });
            this.context.SaveChanges();
        }

        public FinalizeOrderDTO GetDataForFinalizeOrder(Guid userId)
        {
            var user = this.context.Users.Include(x => x.CartItems).SingleOrDefault(x => x.Id == userId);
            var items = new List<Item>();
            user.CartItems.ForEach(x =>
            {
                items.Add(this.context.Items.SingleOrDefault(i => i.Id == x.ItemId));
            });

            int priceSum = 0;

            items.ForEach(x =>
           {
               priceSum += (x.DiscountedPrice != null ? x.DiscountedPrice.Value : x.OriginalPrice) * user.CartItems.Single(y => y.ItemId == x.Id).Quantity;
           });         

            var dto = new FinalizeOrderDTO()
            {
                BillingData = new UserBillingDataDTO(user),
                PaymentMethods = new List<string>() { EnumExtensionMethods.GetDescription(PaymentMethod.AdvancePayment),
                                                        EnumExtensionMethods.GetDescription(PaymentMethod.OnlineCreditCard),
                                                       EnumExtensionMethods.GetDescription(PaymentMethod.WhenDelivered)},
                PriceSum = priceSum
            };

            return dto;
        }
    }
}
