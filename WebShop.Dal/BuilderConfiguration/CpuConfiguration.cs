using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebShop.Dal.DataBaseSeed;
using WebShop.Dal.Models;

namespace WebShop.Dal.BuilderConfiguration
{
    class CpuConfiguration : IEntityTypeConfiguration<Cpu>
    {

        private readonly ISeedService seedService;

        public CpuConfiguration(ISeedService seedService)
        {
            this.seedService = seedService;
        }

        public void Configure(EntityTypeBuilder<Cpu> builder)
        {
            builder.HasData(this.seedService.Cpus);
        }
    }
}
