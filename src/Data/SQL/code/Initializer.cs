using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using RestFull.Data.SQL.Repository;

namespace RestFull.Data.SQL
{
    public class Initializer
    {
        public static async Task InitializeAsync(IdentityUserRepository userManager, RoleRepository roleManager)
        {
            if (await roleManager.FindByNameAsync("admin") == null)
            {
                await roleManager.CreateAsync(new IdentityRole("admin"));
            }
            if (await roleManager.FindByNameAsync("user") == null)
            {
                await roleManager.CreateAsync(new IdentityRole("user"));
            }
            if (await roleManager.FindByNameAsync("restaurant manager") == null)
            {
                await roleManager.CreateAsync(new IdentityRole("restaurant manager"));
            }
            //TODO: Base admin
            //string adminEmail = "admin@gmail.com";
            //string password = "_Aa123456";
            //if (await userManager.FindByNameAsync(adminEmail) == null)
            //{
            //    var admin = new User { Email = adminEmail, UserName = adminEmail };
            //    IdentityResult result = await userManager.CreateAsync(admin, password);
            //    if (result.Succeeded)
            //    {
            //        await userManager.AddToRoleAsync(admin, "admin");
            //    }
            //}
        }
    }
}
