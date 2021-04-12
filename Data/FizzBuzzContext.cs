using Fizz.Models;
using Microsoft.EntityFrameworkCore;

namespace Fizz.Data
{
    public class FizzBuzzContext : DbContext
    {
        public DbSet<FizzBuzz> FizzBuzz { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
           => options.UseSqlite(@"Data Source=C:\Users\Jan\OneDrive\Studia\SemestrVI\.NET\PS3,4\Fizz\fizzbuzz.db");
    }
}