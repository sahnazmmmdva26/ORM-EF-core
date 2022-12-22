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
    internal class SizeService : IService<Size>
    {
        public void Add(Size model)
        {
            if(model != null)
            {
            using (AppDbContext context = new AppDbContext())
            {
                context.sizes.Add(model);
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
            Size existed;
            using (AppDbContext context = new AppDbContext())
            {
                existed = context.sizes.FirstOrDefault(p => p.Id == Id);
                if (existed != null)
                    context.sizes.Remove(existed);
                context.SaveChanges();
            }
        }

        public List<Size> GetAll()
        {

            List<Size> list;
            using (AppDbContext context = new AppDbContext())
            {
                list = context.sizes.ToList();
            }
            return list;
        }

        public Size GetById(int Id)
        {
            Size size;
            using (AppDbContext context = new AppDbContext())
            {
                size = context.sizes.FirstOrDefault(p => p.Id == Id);
            }
            return size;
        }

        public void Update(Size model)
        {
            Size size;
            using (AppDbContext context = new AppDbContext())
            {
                size = context.sizes.FirstOrDefault(p => p.Id == model.Id);
                size.Name = model.Name;
                /*
                 context.pizzas.Update(pizza);
                 */
                context.SaveChanges();
            }
        }
    }
}
