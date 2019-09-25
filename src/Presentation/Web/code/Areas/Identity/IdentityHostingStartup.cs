using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(RestFull.Presentation.Web.Areas.Identity.IdentityHostingStartup))]
namespace RestFull.Presentation.Web.Areas.Identity
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