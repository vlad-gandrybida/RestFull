using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RestFull.Business.Interfaces.Services;
using RestFull.Data.Entities.Restaurant;

namespace RestFull.Presentation.Web.Pages.Admin.Restaurants
{
    public class IndexModel : PageModel
    {
        private IRestaurantService RestaurantService { get; }
        public IEnumerable<Restaurant> Restaurants { get; private set; }

        public IndexModel(IRestaurantService restaurantService)
        {
            RestaurantService = restaurantService;
        }

        public void OnGet()
        {
            Restaurants = RestaurantService.GetRestaurants();
        }
    }
}