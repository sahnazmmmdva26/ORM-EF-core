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
    internal class IngredientService : IService<Ingredient>
    {
        public void Add(Ingredient model)
        {
            if (model != null)
            {
            using (AppDbContext context = new AppDbContext())
            {
               
                context.ingredients.Add(model);
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
            Ingredient existed;
            using (AppDbContext context = new AppDbContext())
            {
                existed = context.ingredients.FirstOrDefault(p => p.Id == Id);
                if (existed != null)
                    context.ingredients.Remove(existed);
                context.SaveChanges();
            }
        }

        public List<Ingredient> GetAll()
        {
            List<Ingredient> list;
            using (AppDbContext context = new AppDbContext())
            {
                list = context.ingredients.ToList();
            }
            return list;
        }

        public Ingredient GetById(int Id)
        {
            Ingredient ing;
            using (AppDbContext context = new AppDbContext())
            {
                ing = context.ingredients.FirstOrDefault(p => p.Id == Id);
            }
            return ing;
        }

        public void Update(Ingredient model)
        {
            Ingredient ing;
            using (AppDbContext context = new AppDbContext())
            {
                ing = context.ingredients.FirstOrDefault(p => p.Id == model.Id);
                ing.Name = model.Name;
                /*
                 context.pizzas.Update(pizza);
                 */
                context.SaveChanges();
            }
        }
    }
}
