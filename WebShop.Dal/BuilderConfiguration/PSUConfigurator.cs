using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebShop.Dal.DataBaseSeed;
using WebShop.Dal.Models;

namespace WebShop.Dal.BuilderConfiguration
{
    class PSUConfigurator : IEntityTypeConfiguration<PowerSupply>
    {

        private readonly ISeedService seedService;

        public PSUConfigurator(ISeedService seedService)
        {
            this.seedService = seedService;
        }

        public void Configure(EntityTypeBuilder<PowerSupply> builder)
        {
            builder.HasData(this.seedService.PowerSupplies);
        }
    }
}
