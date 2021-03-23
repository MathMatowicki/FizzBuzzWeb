using System.ComponentModel.DataAnnotations;
using System;
namespace Fizz.Models
{
    public class FizzBuzz
    {
        [Display(Name = "Please input integer from range 1-1000")]
        [Range(1, 1000)]
        [Required]
        public int Value { get; set; }
        public DateTime Date { get; set; }
        public string GetResult()
        {
            string result = "Input: ";
            Date = DateTime.Now;
            if (Value % 3 == 0)
            {
                result += "Fizz";
            }
            if (Value % 5 == 0)
            {
                result += "Buzz";
            }
            if (result == "Input: ")
            {
                return "Number: " + Convert.ToString(Value) + " doesn't match the criteria of Fizz / Buzz";
            }
            return result;
        }
    }
}