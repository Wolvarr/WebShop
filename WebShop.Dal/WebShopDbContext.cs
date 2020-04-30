using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using WebShop.Dal.BuilderConfiguration;
using WebShop.Dal.DataBaseSeed;
using WebShop.Dal.Models;

namespace WebShop.Dal.Context
{
    public class WebShopDbContext : IdentityDbContext<User, IdentityRole<Guid>, Guid>
    {

        private readonly ISeedService seedService;

        public WebShopDbContext(DbContextOptions options, ISeedService seedService)
            : base(options)
        {
            this.seedService = seedService;
        }

        //tables
        public DbSet<Item> Items { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<CompletPC> CompletPCs { get; set; }
        public DbSet<PC_Drive> PC_Drives { get; set; }
        public DbSet<PC_Memory> PC_Memories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Hardware>().HasBaseType<Item>();
            modelBuilder.Entity<Case>().HasBaseType<Item>();
            modelBuilder.Entity<Cpu>().HasBaseType<Hardware>();
            modelBuilder.Entity<GraphicsCard>().HasBaseType<Hardware>();
            modelBuilder.Entity<HardDrive>().HasBaseType<Hardware>();
            modelBuilder.Entity<Memory>().HasBaseType<Hardware>();
            modelBuilder.Entity<Motherboard>().HasBaseType<Hardware>();
            modelBuilder.Entity<PowerSupply>().HasBaseType<Hardware>();

            // Egy user 1x értékelhet 1 terméket.
            modelBuilder.Entity<Rating>().HasAlternateKey(
                r => new { r.ItemId, r.UserId });

            modelBuilder.Entity<Order>(e =>
            {
                e.OwnsOne(o => o.BillingAddress);
                e.OwnsOne(o => o.ShippingAddress);
            });

            modelBuilder.Entity<User>(u =>
            {
                u.OwnsOne(o => o.BillingAddress);
                u.OwnsOne(o => o.ShippingAddress);
            });


            modelBuilder.ApplyConfiguration(new CompletPcConfiguration(seedService));
            modelBuilder.ApplyConfiguration(new CaseConfiguration(seedService));
            modelBuilder.ApplyConfiguration(new CpuConfiguration(seedService));
            modelBuilder.ApplyConfiguration(new GraphicsConfigurator(seedService));
            modelBuilder.ApplyConfiguration(new MemoryConfigurator(seedService));
            modelBuilder.ApplyConfiguration(new MotherboardConfigurator(seedService));
            modelBuilder.ApplyConfiguration(new PSUConfigurator(seedService));
            modelBuilder.ApplyConfiguration(new HardDriveConfiguration(seedService));
            //TODO seed miatt minden itemtypra
        }
    }
}
