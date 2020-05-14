using System;
using System.Collections.Generic;
using WebShop.Bll.DTO;
using WebShop.Bll.Specifications;

namespace WebShop.Bll.ServiceInterfaces
{
    public interface IItemService
    {
        PagedResult<ItemHeader> GetAllItems(ItemSpecification specification);

        ItemFullViewDTO GetItemById(Guid id);

        List<ItemHeader> GetAllDiscountedItems();

        List<ItemHeader> GetAllHighLightedItems();
    }
}
