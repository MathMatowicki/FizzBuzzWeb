using System.ComponentModel.DataAnnotations;

namespace FizzBuzzWeb.Models
{
    public class FizzBuzz
    {
        [Display(Name = "Please input integer from range 1-1000")]
        [Range(1, 1000)]
        [Required]
        public int Value { get; set; }
    }

}