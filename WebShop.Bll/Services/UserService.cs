using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using WebShop.Bll.DTO;
using WebShop.Bll.Exceptions;
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

        public void SubscriebeToNotification(Guid userId, Guid itemId)
        {
            var User = this.context.Users.SingleOrDefault(u => u.Id == userId);
            var Item = this.context.Items.SingleOrDefault(u => u.Id == itemId);

            this.context.UserSubscriptions.Add(new UserSubscription(User, Item));
            this.context.SaveChanges();
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
    }
}
