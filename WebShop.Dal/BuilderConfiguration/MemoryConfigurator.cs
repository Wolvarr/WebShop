using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebShop.Dal.DataBaseSeed;
using WebShop.Dal.Models;

namespace WebShop.Dal.BuilderConfiguration
{
    class MemoryConfigurator : IEntityTypeConfiguration<Memory>
    {

        private readonly ISeedService seedService;

        public MemoryConfigurator(ISeedService seedService)
        {
            this.seedService = seedService;
        }

        public void Configure(EntityTypeBuilder<Memory> builder)
        {
            builder.HasData(this.seedService.Memories);
        }
    }
}
