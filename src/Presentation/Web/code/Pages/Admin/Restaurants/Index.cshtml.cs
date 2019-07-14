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
    public class IndexModel : PageModel
    {
        private readonly RestFull.Data.SQL.RestFullDbContext _context;

        public IndexModel(RestFull.Data.SQL.RestFullDbContext context)
        {
            _context = context;
        }

        public IList<Restaurant> Restaurant { get;set; }

        public async Task OnGetAsync()
        {
            Restaurant = await _context.Restaurants.ToListAsync();
        }
    }
}
