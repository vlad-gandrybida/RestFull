using Microsoft.AspNetCore.Identity;
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
            services.AddScoped<ITableRepository, TableRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
        }

        public static void AddRestFullDatabase(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<RestFullDbContext>(options =>
                options.UseSqlServer(connectionString));
        }

        public static void AddRestFullIdentity(this IServiceCollection services)
        {
            services.AddIdentity<IdentityUser, IdentityRole>()
                .AddEntityFrameworkStores<RestFullDbContext>()
                .AddUserManager<IdentityUserRepository>()
                .AddRoleManager<RoleRepository>()
                .AddDefaultTokenProviders();
        }
    }
}
