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
        void CreateOrder(CreateOrderDTO orderDto);
        FinalizeOrderDTO GetDataForFinalizeOrder(Guid userId);

        void AddItemToCart(Guid userId, Guid itemId, int quantity);

        void AddAllItemsToCart(Guid userId, List<Guid> items);

        void RemoveSubscription(Guid userId, Guid itemId);
    }
}
