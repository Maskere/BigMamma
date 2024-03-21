using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    public class Pizza
    {
        #region Instance Field
        private int _price;
        private string _name;
        private int _pizzaId;
        private static int _pizzaIDCounter=0;
        #endregion

        #region Constructor
        public Pizza(string Name, int Price) 
        {
            _name = Name;
            _price = Price;
            _pizzaId = _pizzaIDCounter++;
        }
        #endregion

        #region Properties
        public int Price
        { 
            get { return _price; } 
        }
        public string Name
        {
            get { return _name; }
        }
        public int PizzaId
        { 
            get { return _pizzaId; } 
        }
        #endregion

        #region Methods
        public override string ToString() 
        {
            return $"{Name} - Price:{Price}";
        }
        #endregion
    }
}
