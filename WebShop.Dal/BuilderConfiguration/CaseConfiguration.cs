using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebShop.Dal.DataBaseSeed;
using WebShop.Dal.Models;

namespace WebShop.Dal.BuilderConfiguration
{
    public class CaseConfiguration : IEntityTypeConfiguration<Case>
    {

        private readonly ISeedService seedService;

        public CaseConfiguration(ISeedService seedService)
        {
            this.seedService = seedService;
        }

        public void Configure(EntityTypeBuilder<Case> builder)
        {
            builder.HasData(this.seedService.Cases);
        }
    }
}
