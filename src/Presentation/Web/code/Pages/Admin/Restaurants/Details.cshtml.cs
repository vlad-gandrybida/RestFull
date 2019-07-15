using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RestFull.Business.Interfaces.Services;
using RestFull.Common.Enums;
using RestFull.Data.Entities.Restaurant;
using RestFull.Data.SQL;

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

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Restaurant = await _restaurantService.GetRestaurantById(id.Value);

            if (Restaurant == null)
            {
                return NotFound();
            }

            return Page();
        }
    }
}
