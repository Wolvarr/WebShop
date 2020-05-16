using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using WebShop.Dal.Context;
using WebShop.Dal.Models;

namespace WebShop.Dal.DataBaseSeed
{
    public static class UserSeeder
    { 
        public static void SeedUsers(UserManager<User> userManager, WebShopDbContext context)
        {
            if (userManager.FindByEmailAsync("asd@asd.hu").Result == null)
            {
                User testUser = new User
                {
                    Id = new Guid("12345678-0000-0000-0000-120000000000"),
                    UserName = "ASD@ASD.HU",
                    NormalizedUserName = "ASD@ASD.HU",
                    Email = "asd@asd.hu",
                    NormalizedEmail = "ASD@ASD.HU"
                };

                IdentityResult result = userManager.CreateAsync(testUser, "Asdf1234.").Result;

                context.Ratings.Add(new Rating()
                {
                    Id = new Guid("12345678-1234-0000-0000-123400000000"),
                    UserId = new Guid("12345678-0000-0000-0000-120000000000"),
                    ItemId = new Guid("10000000-0000-0000-0000-000000000000"),
                    Value = 4
                });

                context.SaveChanges();
            }
        }
    }
}
