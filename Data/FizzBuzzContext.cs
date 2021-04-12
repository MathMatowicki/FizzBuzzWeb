using Fizz.Models;
using Microsoft.EntityFrameworkCore;

namespace Fizz.Data
{
    public class FizzBuzzContext : DbContext
    {
        public DbSet<FizzBuzz> FizzBuzz { get; set; }
    }
}