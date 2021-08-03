using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TrackerBookApplication.Data;
using TrackerBookApplication.Data.Context;

namespace TrackerBookApplication.Pages.CategoryPages
{
    public class DetailsModel : PageModel
    {
        private readonly TrackerBookApplication.Data.Context.StoreContext _context;

        public DetailsModel(TrackerBookApplication.Data.Context.StoreContext context)
        {
            _context = context;
        }

        public Category Category { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Category = await _context.Category.FirstOrDefaultAsync(m => m.NameToken == id);

            if (Category == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
