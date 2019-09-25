using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RestFull.Business.Interfaces.Services;
using RestFull.Data.Entities.Restaurant;

namespace RestFull.Presentation.Web.Pages.Admin.Restaurants
{
    public class DetailsModel : PageModel
    {
        private readonly IRestaurantService _restaurantService;

        public DetailsModel(IRestaurantService restaurantService)
        {
            _restaurantService = restaurantService;
        }

        public Restaurant Restaurant { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Restaurant = await _restaurantService.GetRestaurantById(id);

            if (Restaurant == null)
            {
                return NotFound();
            }

            return Page();
        }
    }
}
