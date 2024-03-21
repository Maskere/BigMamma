using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    public class Controlller
    {
        static MenuCatalog catalog = new MenuCatalog();
        public Controlller() 
        {
            
        }
        public void AddPizza(string pizzaName) 
        {
            Pizza p = new Pizza(pizzaName,0);
            catalog.SavePizza(p);
        }

    }
}
