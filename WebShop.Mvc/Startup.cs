using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WebShop.Dal.Models;
using WebShop.Dal.Context;
using WebShop.Dal.DataBaseSeed;
using WebShop.Bll.Services;
using WebShop.Bll.ServiceInterfaces;
using WebShop.Mvc.Services;
using Microsoft.AspNetCore.Identity.UI.Services;
using System.Threading.Tasks;
using System.Threading;

namespace WebShop
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddIdentity<WebShopUser, IdentityRole<Guid>>()
               .AddEntityFrameworkStores<WebShopDbContext>()
               .AddDefaultTokenProviders();

            services.AddDbContext<WebShopDbContext>(o =>
                   o.UseSqlServer(this.Configuration.GetConnectionString("DefaultConnection"))
                )
                 .AddTransient<ISeedService, SeedService>();

            services.AddAuthentication().AddFacebook(facebookOptions =>
            {
                facebookOptions.AppId = "1495221980637214";
                facebookOptions.AppSecret = "7c33b04e3806e1bda4a44525a6702696";
            });

            services.Configure<EmailSettings>(Configuration.GetSection("EmailSettings"));

            services.AddScoped<IEmailSender, EmailSender>();
            services.AddScoped<IItemService, ItemService>();
            services.AddScoped<IUserService, UserService>();

            services.AddMvc();
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, UserManager<WebShopUser> userManager, RoleManager<IdentityRole<Guid>> roleManager, WebShopDbContext context)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseAuthentication();


            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapRazorPages();

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });

            //TODO: So ugly, debug thread issue with dbcontext error in SeedUsers
            UserSeeder.SeedUsers(userManager, roleManager, context).Wait();
        }
    }
}
