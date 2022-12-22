using Microsoft.EntityFrameworkCore;
using PizzamizzaTask.DAL;
using PizzamizzaTask.Helper;
using PizzamizzaTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzamizzaTask.Services
{
    internal class PizzaService : IService<Pizza>
    {
        public void Add(Pizza model)
        {
            if(model != null)
            {
            using (AppDbContext context = new AppDbContext())
            {
                context.pizzas.Add(model);
                context.SaveChanges();
            }
            }
            else
            {
                Console.WriteLine("obyekt null di");
            }
        
        }

        public void Delete(int Id)
        {
            Pizza existed;
            using (AppDbContext context = new AppDbContext())
            {
                existed = context.pizzas.FirstOrDefault(p => p.Id == Id);
                if(existed != null)
                    context.pizzas.Remove(existed);
                context.SaveChanges();
            }
        }

        public List<Pizza> GetAll()
        {
            List<Pizza> list;
            using (AppDbContext context = new AppDbContext())
            {
                list = context.pizzas.ToList();
            }
            return list;
        }

        public Pizza GetById(int Id)
        {
            Pizza pizza;
            using (AppDbContext context = new AppDbContext())
            {
                pizza = context.pizzas.FirstOrDefault(p => p.Id == Id);
            }
            return pizza;
        }

        public void Update(Pizza model)
        {
            Pizza pizza;
            using (AppDbContext context = new AppDbContext())
            {
                pizza = context.pizzas.FirstOrDefault(p => p.Id == model.Id);
                pizza.Name=model.Name;
                /*
                 context.pizzas.Update(pizza);
                 */
                context.SaveChanges();
            }
        }
    }
}
