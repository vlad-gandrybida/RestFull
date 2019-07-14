using Microsoft.Extensions.DependencyInjection;
using RestFull.Business.Interfaces.Services;
using RestFull.Business.Logic.Services;

namespace RestFull.Business.Extensions
{
    public static class ServiceProviderExtensions
    {
        public static void AddRestFullServices(this IServiceCollection services)
        {
            services.AddScoped<IRestaurantService, RestaurantService>();
            services.AddScoped<IUserService, UserService>();
        }
    }
}
