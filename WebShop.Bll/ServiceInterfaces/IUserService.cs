using System;
using System.Collections.Generic;
using System.Text;
using WebShop.Bll.DTO;

namespace WebShop.Bll.ServiceInterfaces
{
    public interface IUserService
    {
        bool SubscriebeToNotification(Guid userId, Guid itemId);

        List<ItemForShoppingCartDTO> GetAllItemsInCart(Guid userId);

        void RemoveItemFromCart(Guid userId, Guid itemId);

        void EditCartItemQuantity(Guid userId, Guid cartItemId, int quantity);
    }
}
