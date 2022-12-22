using PizzamizzaTask.DAL;
using PizzamizzaTask.Models;
using PizzamizzaTask.Services;
using System.Threading.Channels;

namespace PizzamizzaTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            PizzaService pizzaService = new PizzaService();


            //Pizza pizza = new Pizza
            //{
            //    Name="efwe"
            //};
            //Pizza pizza1 = null;
            //pizzaService.Add(pizza);

            //Pizza pizza2 = pizzaService.GetById(1);
            //if (pizza2 != null)
            //{
            //    Console.WriteLine(pizza2.Name);
            //}
            //else
            //{
            //    Console.WriteLine("bele pizza yoxdur");
            //}

            //List<Pizza> pizzas = pizzaService.GetAll();
            //foreach (var item in pizzas)
            //{
            //    Console.WriteLine(item.Name);
            //}

            //Pizza pizza = new Pizza
            //{
            //    Id = 1,
            //    Name="sasjaks"
            //};

            //pizzaService.Update(pizza);
        }
    }
}