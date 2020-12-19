using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPractice.Models;

namespace RazorPractice.Data
{
    public class RazorPracticeContext : DbContext
    {
        public RazorPracticeContext (DbContextOptions<RazorPracticeContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPractice.Models.Books> Books { get; set; }
    }
}
