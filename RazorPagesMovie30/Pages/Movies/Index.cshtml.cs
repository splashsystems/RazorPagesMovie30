using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie30.Data;
using RazorPagesMovie30.Models;

namespace RazorPagesMovie30.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesMovie30.Data.RazorPagesMovie30Context _context;

        public IndexModel(RazorPagesMovie30.Data.RazorPagesMovie30Context context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
