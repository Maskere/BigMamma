using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    public class UserDialog
    {
        MenuCatalog _menuCatalog;

        public UserDialog(MenuCatalog menuCatalog) 
        {
            _menuCatalog = menuCatalog;
        }
        Pizza GetNewPizza() 
        {
            Pizza pizzaItem = new Pizza("", 100);


            return pizzaItem;
        }
        public int MainMenuChoice(List<string> menuItems) 
        {
            Console.Clear();
            Console.WriteLine("Pick your choice");
            Console.WriteLine("Options:");

            foreach (string choice in menuItems)
            {
                Console.WriteLine(choice);
            }
            Console.WriteLine("Enter option# ");
            string input = Console.ReadKey().KeyChar.ToString();

            try
            {
                int result = Int32.Parse(input);
                return result;
            }
            catch (FormatException)
            {
                Console.WriteLine($"Unable to parse '{input}'");
            }

            return -1;
        }
        public void Run() 
        {
            bool proceed = true;
            List<string> mainMenuList = new List<string>()
            {
                "0. Quit",
                "1. Create new pizza",
                "2. Print menu",
                "3. Find specific pizza"
            };

            while (proceed) 
            {
                int MenuChoice = MainMenuChoice(mainMenuList);
                Console.WriteLine();
                switch (MenuChoice) 
                {
                    case 0:
                        proceed = false;
                        Console.WriteLine("Quitting");
                        break;
                    case 1:
                        try
                        {
                        Console.WriteLine("Enter your pizza name: ");
                        string pizzaName = Console.ReadLine();
                        Pizza pizza = new Pizza(pizzaName, 100);
                        _menuCatalog.SavePizza(pizza);
                        Console.WriteLine($"You created {pizza} with id: {pizza.PizzaId}");
                         
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("No pizza created");
                        }
                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey();
                        break;
                    case 2:
                        _menuCatalog.PrintMenu();
                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine("Choose your pizza: ");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
