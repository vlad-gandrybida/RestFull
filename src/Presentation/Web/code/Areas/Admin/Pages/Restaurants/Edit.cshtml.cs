﻿using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RestFull.Data.Entities.Restaurant;

namespace RestFull.Presentation.Web.Pages.Admin.Restaurants
{
    public class EditModel : PageModel
    {
        private readonly RestFull.Data.SQL.RestFullDbContext _context;

        public EditModel(RestFull.Data.SQL.RestFullDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Restaurant Restaurant { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
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

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Restaurant).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RestaurantExists(Restaurant.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool RestaurantExists(string id)
        {
            return _context.Restaurants.Any(e => e.Id == id);
        }
    }
}
