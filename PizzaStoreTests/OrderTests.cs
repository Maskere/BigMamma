using Microsoft.VisualStudio.TestTools.UnitTesting;
using PizzaStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore.Tests
{
    [TestClass()]
    public class OrderTests
    {
        [TestMethod()]
        public void CalculateTotalPriceTest()
        {
            //AAA


            //Arrange
            Pizza pizza = new Pizza("a",100);
            Customer customer = new Customer("Miki");
            Order order = new Order(customer, pizza, 2);

            //Act
            order.CalculateTotalPrice();

            //Assert
            Assert.AreEqual(240, order.TotalPrice);
        }
    }
}