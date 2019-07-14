using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RestFull.Data.Entities.Restaurant;
using RestFull.Data.SQL;

namespace RestFull.Presentation.Web.Pages.Admin.Restaurants
{
    public class DetailsModel : PageModel
    {
        private readonly RestFull.Data.SQL.RestFullDbContext _context;

        public DetailsModel(RestFull.Data.SQL.RestFullDbContext context)
        {
            _context = context;
        }

        public Restaurant Restaurant { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Restaurant = await _context.Restaurants.FirstOrDefaultAsync(m => m.Id == id);

            if (Restaurant == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
