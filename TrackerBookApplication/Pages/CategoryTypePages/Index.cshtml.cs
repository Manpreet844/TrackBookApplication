using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TrackerBookApplication.Data;
using TrackerBookApplication.Data.Context;

namespace TrackerBookApplication.Pages.CategoryTypePages
{
    public class IndexModel : PageModel
    {
        private readonly TrackerBookApplication.Data.Context.StoreContext _context;

        public IndexModel(TrackerBookApplication.Data.Context.StoreContext context)
        {
            _context = context;
        }

        public IList<CategoryType> CategoryType { get;set; }

        public async Task OnGetAsync()
        {
            CategoryType = await _context.CategoryType.ToListAsync();
        }
    }
}
