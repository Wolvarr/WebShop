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
            builder.HasOne(pc => pc.Case)
                .WithMany()
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(pc => pc.Motherboard)
                .WithMany()
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(pc => pc.Cpu)
                .WithMany()
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(pc => pc.Gpu)
                .WithMany()
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(pc => pc.PowerSupply)
                .WithMany()
                .OnDelete(DeleteBehavior.Restrict);

                builder.HasData(this.seedService.CompletPCs);
        }
    }
}
