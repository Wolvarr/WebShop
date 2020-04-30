using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WebShop.Dal.BuilderConfiguration;
using WebShop.Dal.Models;

namespace WebShop.Dal.Context
{
    public class WebShopDbContext : IdentityDbContext<User, IdentityRole<Guid>, Guid>
    {
        public WebShopDbContext(DbContextOptions options)
            : base(options)
        {
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

            modelBuilder.ApplyConfiguration(new CompletPcConfiguration());
        }
    }
}
