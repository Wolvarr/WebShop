using System;
using System.Collections.Generic;
using WebShop.Bll.DTO;
using WebShop.Bll.Specifications;
using WebShop.Dal.Models;

namespace WebShop.Bll.ServiceInterfaces
{
    public interface IItemService
    {
        PagedResult<ItemHeader> GetAllItems(ItemSpecification specification);

        ItemFullViewDTO GetItemById(Guid id);

        List<ItemHeader> GetAllDiscountedItems();

        List<ItemHeader> GetAllHighLightedItems();

        void AddItemToCart(Guid userId, Guid itemId, int quantity);
    }
}
