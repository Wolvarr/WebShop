using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebShop.Dal.DataBaseSeed;
using WebShop.Dal.Models;

namespace WebShop.Dal.BuilderConfiguration
{
    class HardDriveConfiguration : IEntityTypeConfiguration<HardDrive>
    {

        private readonly ISeedService seedService;

        public HardDriveConfiguration(ISeedService seedService)
        {
            this.seedService = seedService;
        }

        public void Configure(EntityTypeBuilder<HardDrive> builder)
        {
            builder.HasData(this.seedService.HardDrives);
        }
    }
}
