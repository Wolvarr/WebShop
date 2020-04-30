using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebShop.Dal.DataBaseSeed;
using WebShop.Dal.Models;

namespace WebShop.Dal.BuilderConfiguration
{
    class GraphicsConfigurator : IEntityTypeConfiguration<GraphicsCard>
    {

        private readonly ISeedService seedService;

        public GraphicsConfigurator(ISeedService seedService)
        {
            this.seedService = seedService;
        }

        public void Configure(EntityTypeBuilder<GraphicsCard> builder)
        {
            builder.HasData(this.seedService.Graphics);
        }
    }
}
