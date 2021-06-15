using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Fizz.Data;
using Fizz.Models;
using Microsoft.AspNetCore.Authorization;

namespace Fizz.Pages_History
{
    [Authorize]
    public class IndexModel : PageModel
    {
        private readonly Fizz.Data.FizzBuzzContext _context;

        public IndexModel(Fizz.Data.FizzBuzzContext context)
        {
            _context = context;
        }

        public IList<FizzBuzz> FizzBuzz { get; set; }

        public async Task OnGetAsync()
        {
            FizzBuzz = await _context.FizzBuzz.OrderByDescending(d => d.Date).Take(20).ToListAsync();
        }
    }
}
