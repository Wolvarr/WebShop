using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebShop.Dal.DataBaseSeed;
using WebShop.Dal.Models;

namespace WebShop.Dal.BuilderConfiguration
{
    public class CompletPcConfiguration : IEntityTypeConfiguration<CompletPC>
    {
        private readonly ISeedService seedService;

        public CompletPcConfiguration(ISeedService seedService)
        {
            this.seedService = seedService;
        }

        public void Configure(EntityTypeBuilder<CompletPC> builder)
        {
            builder.HasData(this.seedService.CompletPCs);
        }
    }
}
