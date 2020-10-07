using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(WebShop.Mvc.Areas.Identity.IdentityHostingStartup))]
namespace WebShop.Mvc.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
            });
        }
    }
}