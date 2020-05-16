using System;
using System.Collections.Generic;
using System.Text;
using WebShop.Bll.DTO;

namespace WebShop.Bll.ServiceInterfaces
{
    public interface IUserService
    {
        void SubscriebeToNotification(Guid userId, Guid itemId);

        List<ItemForShoppingCartDTO> GetAllItemsInCart(Guid userId);

        void RemoveItemFromCart(Guid userId, Guid itemId);

    }
}
