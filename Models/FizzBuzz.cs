using System.ComponentModel.DataAnnotations;

namespace FizzBuzzWeb.Models
{
    public class FizzBuzz
    {
        [Display(Name = "Podaj proszę liczbę całkowitą z zakresu 1-1000")]
        [Range(1, 1000)]
        [Required]
        public int value { get; set; }
    }

}