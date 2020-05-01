using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using WebShop.Bll.DTO;
using WebShop.Bll.ServiceInterfaces;
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

        public CpuDto GetCpuById(Guid cpuId)
        {
            return new CpuDto(this.context.Items.SingleOrDefault(x => x.Id == cpuId));
        }

        public PagedResult<AbstractItemDto> GetAllItems()
        {
            var results = this.context.Items
                .Include(x => x.Ratings)
                .Select(x => new AbstractItemDto(x))
                .ToList();

            return new PagedResult<AbstractItemDto>
            {
                AllResultsCount = results.Count,
                Results = results,
                PageNumber = 1,
                PageSize = results.Count
            };
        }



        public AbstractItemDto GetItemById(Guid id)
        {
            return new AbstractItemDto(this.context.Items
                .Include(x => x.Ratings)
                .SingleOrDefault(x => x.Id == id));
        }
    }
}
