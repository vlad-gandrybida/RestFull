using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RestFull.Common.Enums.Restaurant;
using RestFull.Data.Entities.Restaurant;

namespace RestFull.Presentation.Web.Pages.Admin.Restaurants
{
    public class CreateModel : PageModel
    {
        private readonly RestFull.Data.SQL.RestFullDbContext _context;
        private readonly IHtmlHelper htmlHelper;

        public IEnumerable<SelectListItem> States { get; set; }
        public CreateModel(RestFull.Data.SQL.RestFullDbContext context, IHtmlHelper htmlHelper)
        {
            _context = context;
            this.htmlHelper = htmlHelper;
        }

        public IActionResult OnGet()
        {
            States = htmlHelper.GetEnumSelectList<RestaurantState>();
            return Page();
        }

        [BindProperty]
        public Restaurant Restaurant { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Restaurants.Add(Restaurant);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}