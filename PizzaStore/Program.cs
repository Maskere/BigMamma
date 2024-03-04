using System;

namespace PizzaStore 
{
    class Program 
    {
        static void Main(string[] args) 
        {
            BigMamma bigMamma = new BigMamma();
            bigMamma.Start();

            Console.WriteLine("Press any key to close the program...");
        }
    }
}