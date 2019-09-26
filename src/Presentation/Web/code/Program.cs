using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using RestFull.Data.Extensions;

namespace RestFull.Presentation.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateWebHostBuilder(args).Build();

            host.AddInitialData().Wait();

            host.Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
