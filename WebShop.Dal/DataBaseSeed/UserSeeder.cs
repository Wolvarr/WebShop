using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using WebShop.Dal.Context;
using WebShop.Dal.Models;

namespace WebShop.Dal.DataBaseSeed
{
    public static class UserSeeder
    {
        private static readonly string[] Roles = new string[] { "Administrator", "Costumer" };

        public static async Task SeedUsers(UserManager<WebShopUser> userManager, RoleManager<IdentityRole<Guid>> roleManager, WebShopDbContext context)
        {
            if (!await roleManager.RoleExistsAsync("Administrator"))
                await roleManager.CreateAsync(new IdentityRole<Guid> { Name = "Administrator" });

            if (userManager.FindByEmailAsync("admin@asd.hu").Result == null)
            {
                WebShopUser testUser = new WebShopUser
                {
                    NickName = "Admin Admin",
                    Id = new Guid("12345678-0000-0000-0000-120000000000"),
                    UserName = "admin@asd.hu",
                    NormalizedUserName = "ASD@ASD.HU",
                    Email = "admin@asd.hu",
                    NormalizedEmail = "ASD@ASD.HU",
                    BillingAddress = new Address()
                    {
                        ZipCode = "1091",
                        Country = "Magyarország",
                        City = "Budapest",
                        Street = "Random utca",
                        HouseNumberAndDoor = "13,  3/12",
                    },
                };

                IdentityResult result =  userManager.CreateAsync(testUser, "Asdf1234.").Result;

                var addToRoleResult =  userManager.AddToRoleAsync(testUser, "Administrator");


                context.Ratings.Add(new Rating()
                {
                    Id = new Guid("12345678-1234-0000-0000-123400000000"),
                    UserId = new Guid("12345678-0000-0000-0000-120000000000"),
                    ItemId = new Guid("10000000-0000-0000-0000-000000000000"),
                    Value = 4
                });

                context.Comments.Add(new Comment()
                {
                    Id = Guid.NewGuid(),
                    UserId = new Guid("12345678-0000-0000-0000-120000000000"),
                    ItemId = new Guid("10000000-0000-0000-0000-000000000000"),
                    CommentText = "Nagyon jó termék, évek óta használom hiba nélkül.",
                    Date = DateTime.Now
                });

                await context.SaveChangesAsync();
            }
        }
    }
}
