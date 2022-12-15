using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product() { Id = 1, CategroyId = 2, 
                ProductName = "Masa", UnitPrice=500,UnitsInStock=3 };

            Product product2 = new Product() { Id = 2, CategroyId = 5, 
                ProductName = "Kalem", UnitPrice=35,UnitsInStock=5 };


            //case sensitive
            //PascalCase   //camelCase
            ProductManager productManager = new ProductManager();
            productManager.Add();


            Console.ReadLine();
        }
    }
}
