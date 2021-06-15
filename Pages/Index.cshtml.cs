using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;
using Fizz.Models;
using Microsoft.AspNetCore.Authorization;

namespace Fizz.Pages
{
    [AllowAnonymous]
    public class IndexModel : PageModel
    {
        [BindProperty]
        public FizzBuzz Fizz { get; set; }
        private readonly Fizz.Data.FizzBuzzContext _context;

        public IndexModel(Fizz.Data.FizzBuzzContext context)
        {
            _context = context;
        }


        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            Fizz.Result = Fizz.GetResult();
            if (User.Identity.IsAuthenticated) { Fizz.UserID = User.Identity.Name; }

            HttpContext.Session.SetString("SessionFizzValue",
                  JsonConvert.SerializeObject(Fizz));
            _context.FizzBuzz.Add(Fizz);
            await _context.SaveChangesAsync();
            return Page();
        }
    }
}