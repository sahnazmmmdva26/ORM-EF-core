using Microsoft.EntityFrameworkCore;
using PizzamizzaTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzamizzaTask.DAL
{
    internal class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=DESKTOP-59QHG10;Database=PizzaMizza;Trusted_Connection=True;Integrated Security=true;Encrypt=false;");
        }
        public DbSet<Pizza> pizzas { get; set; }
        public DbSet<Size> sizes { get; set; }
        public DbSet<Ingredient> ingredients { get; set; }
    }
}
