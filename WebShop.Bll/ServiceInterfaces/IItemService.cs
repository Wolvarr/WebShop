using System;
using System.Collections.Generic;
using System.Text;
using WebShop.Bll.DTO;
using WebShop.Dal.Models;

namespace WebShop.Bll.ServiceInterfaces
{
    public interface IItemService
    {
        PagedResult<AbstractItemDto> GetAllItems();

        AbstractItemDto GetItemById(Guid id);
        CpuDto GetCpuById(Guid id);
    }
}
