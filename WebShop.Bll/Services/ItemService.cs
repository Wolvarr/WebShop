using System;
using System.Linq;
using WebShop.Bll.DTO;
using WebShop.Dal.Context;

namespace WebShop.Bll.Services
{
    public class ItemService
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

    }
}
