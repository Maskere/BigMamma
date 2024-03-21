using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    public class MenuCatalog
    {
        List<Pizza> _pizzas;
        Pizza pizza = new Pizza("",0);
        public MenuCatalog() 
        {
            _pizzas = new List<Pizza>();
        }
        public void SavePizza(Pizza pizza)
        {
            _pizzas.Add(pizza);
        }
        public void DeletePizza(Pizza pizza) 
        {
            _pizzas.Remove(pizza);
        }
        public void PrintMenu()
        {
            foreach (Pizza pizzas in _pizzas) 
            {
                Console.WriteLine(pizzas);
            }
        }
        public override string ToString()
        {
            return $"{pizza.PizzaId}";
        }
    }
}
