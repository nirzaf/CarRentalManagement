using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(CarRentalManagement.Server.Areas.Identity.IdentityHostingStartup))]
namespace CarRentalManagement.Server.Areas.Identity
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