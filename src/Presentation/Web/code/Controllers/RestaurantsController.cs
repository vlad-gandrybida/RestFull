using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RestFull.Business.Interfaces.Services;

namespace RestFull.Presentation.Web.Controllers
{
    public class RestaurantsController : Controller
    {
        private readonly IRestaurantService _restaurantService;

        public RestaurantsController(IRestaurantService restaurantService)
        {
            _restaurantService = restaurantService;
        }

        [Route("/api/getall")]
        public async Task<IActionResult> GetRests()
        {
            var rest = await _restaurantService.GetRestaurants();
            return PartialView("Areas/Admin/Pages/Restaurants/_RestaurantListItems.cshtml",rest);
        }
    }
}