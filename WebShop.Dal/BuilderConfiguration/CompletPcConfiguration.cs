using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using WebShop.Dal.Models;

namespace WebShop.Dal.BuilderConfiguration
{
    public class CompletPcConfiguration : IEntityTypeConfiguration<CompletPC>
    {
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
        }
    }
}
