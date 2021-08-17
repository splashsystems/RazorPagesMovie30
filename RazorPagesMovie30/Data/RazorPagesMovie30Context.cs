using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie30.Models;

namespace RazorPagesMovie30.Data
{
    public class RazorPagesMovie30Context : DbContext
    {
        public RazorPagesMovie30Context (DbContextOptions<RazorPagesMovie30Context> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesMovie30.Models.Movie> Movie { get; set; }
    }
}
