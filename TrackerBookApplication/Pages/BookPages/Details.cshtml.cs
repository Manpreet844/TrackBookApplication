using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TrackerBookApplication.Data;
using TrackerBookApplication.Data.Context;

namespace TrackerBookApplication.Pages.BookPages
{
    public class DetailsModel : PageModel
    {
        private readonly TrackerBookApplication.Data.Context.StoreContext _context;

        public DetailsModel(TrackerBookApplication.Data.Context.StoreContext context)
        {
            _context = context;
        }

        public Book Book { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Book = await _context.Book.FirstOrDefaultAsync(m => m.ISBN == id);

            if (Book == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
