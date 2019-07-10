using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RestFull.Data.Interfaces.Repository;
using RestFull.Data.SQL;
using RestFull.Data.SQL.Repository;

namespace RestFull.Data.Extensions
{
    public static class ServiceProviderExtensions
    {
        public static void AddRestFullRepositories(this IServiceCollection services)
        {
            services.AddScoped<IRestaurantRepository, RestaurantRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<ITableRepository, TableRepository>();
        }

        public static void AddRestFullDatabase(this IServiceCollection services, string connectionString)
        {
            services.AddDbContextPool<RestFullDbContext>(options =>
            {
                options.UseSqlServer(connectionString);
            });
        }
    }
}
