using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fizz.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;

namespace Fizz.Pages
{
    public class LastFizzModel : PageModel
    {
        public FizzBuzz Fizz;
        public String Date;
        public void OnGet()
        {
            var SessionFizz = HttpContext.Session.GetString("SessionFizzValue");
            if (SessionFizz != null)
            {
                Fizz = JsonConvert.DeserializeObject<FizzBuzz>(SessionFizz);
            }
        }
    }
}
