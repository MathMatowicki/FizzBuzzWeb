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

namespace Fizz.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public FizzBuzz Fizz { get; set; }
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                HttpContext.Session.SetString("SessionFizzValue",
                      JsonConvert.SerializeObject(Fizz));
                HttpContext.Session.SetString("SessionDate",
                       DateTime.Now.ToString());
                return Page();
            }
            return Page();
        }
    }
}
