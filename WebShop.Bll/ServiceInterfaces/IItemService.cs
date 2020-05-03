using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using WebShop.Bll.DTO;
using WebShop.Bll.Specifications;
using WebShop.Dal.Models;

namespace WebShop.Bll.ServiceInterfaces
{
    public interface IItemService
    {
        PagedResult<ItemHeader> GetAllItems(ItemSpecification specification);

        ItemFullViewDTO GetItemById(Guid id);
    }
}
