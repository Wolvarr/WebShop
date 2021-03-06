﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using WebShop.Dal.BuilderConfiguration;
using WebShop.Dal.DataBaseSeed;
using WebShop.Dal.Models;
using WebShop.Dal.Models.Users;

namespace WebShop.Dal.Context
{
    public class WebShopDbContext : IdentityDbContext<WebShopUser, IdentityRole<Guid>, Guid>
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
        public DbSet<Order> Orders { get; set; }

        public DbSet<UserCartItem> UserCartItems { get; set; }
        public DbSet<UserSubscription> UserSubscriptions { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Hardware>().HasBaseType<Item>();
            modelBuilder.Entity<Case>().HasBaseType<Item>();
            modelBuilder.Entity<CompletPC>().HasBaseType<Item>();
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

            modelBuilder.Entity<WebShopUser>(u =>
            {
                u.OwnsOne(o => o.BillingAddress);
            });

            modelBuilder.Entity<WebShopUser>(u =>
            {
                u.HasMany(x => x.CartItems)
                .WithOne(c => c.User)
                .HasForeignKey(x => x.UserId);

                u.HasMany(x => x.Comments)
                .WithOne(c => c.User)
                .HasForeignKey(x => x.UserId);
            });

            modelBuilder.Entity<Order>(u =>
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
