using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebShop.Dal.DataBaseSeed;
using WebShop.Dal.Models;

namespace WebShop.Dal.BuilderConfiguration
{
    class MotherboardConfigurator : IEntityTypeConfiguration<Motherboard>
    {

        private readonly ISeedService seedService;

        public MotherboardConfigurator(ISeedService seedService)
        {
            this.seedService = seedService;
        }

        public void Configure(EntityTypeBuilder<Motherboard> builder)
        {
            builder.HasData(this.seedService.Motherboards);
        }
    }
}
