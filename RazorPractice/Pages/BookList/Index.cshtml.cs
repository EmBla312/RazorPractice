using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPractice.Data;
using RazorPractice.Models;

namespace RazorPractice.Pages.BookList
{
    public class IndexModel : PageModel
    {
        private readonly RazorPractice.Data.RazorPracticeContext _context;

        public IndexModel(RazorPractice.Data.RazorPracticeContext context)
        {
            _context = context;
        }

        public IList<Books> Books { get;set; }

        public async Task OnGetAsync()
        {
            Books = await _context.Books.ToListAsync();
        }
    }
}
