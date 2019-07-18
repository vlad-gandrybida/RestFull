using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using RestFull.Data.SQL;
using RestFull.Data.SQL.Repository;

namespace RestFull.Data.Extensions
{
    public static class WebHostExtensions
    {
        public static async Task AddInitialData(this IWebHost host)
        {
            using (IServiceScope scope = host.Services.CreateScope())
            {
                IServiceProvider services = scope.ServiceProvider;
                try
                {
                    var userRepository = services.GetRequiredService<IdentityUserRepository>();
                    var roleRepository = services.GetRequiredService<RoleRepository>();
                    await Initializer.InitializeAsync(userRepository, roleRepository);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
