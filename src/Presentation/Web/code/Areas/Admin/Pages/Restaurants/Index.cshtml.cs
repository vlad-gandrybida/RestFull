using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RestFull.Business.Interfaces.Services;
using RestFull.Data.Entities.Restaurant;

namespace RestFull.Presentation.Web.Pages.Admin.Restaurants
{
    public class IndexModel : PageModel
    {
        private readonly IRestaurantService _restaurantService;

        public IndexModel(IRestaurantService restaurantService)
        {
            _restaurantService = restaurantService;
        }

        public IEnumerable<Restaurant> Restaurant { get;set; }

        public async Task OnGetAsync()
        {

            Restaurant = await _restaurantService.GetRestaurants();

        }
    }
}
