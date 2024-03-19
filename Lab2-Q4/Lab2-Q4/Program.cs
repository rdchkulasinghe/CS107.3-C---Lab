using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Q4
{
    class Product
    {
        public string ProductName { get; set; }
        public decimal Price { get; set; }

        public Product(string productName, decimal price)
        {
            ProductName = productName;
            Price = price;
        }

        public void DisplayProductDetails()
        {
            Console.WriteLine($"Product Name: {ProductName}");
            Console.WriteLine($"Price: ${Price}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product("Laptop", 660.99m);
            Product product2 = new Product("Smartphone", 400.99m);
            Product product3 = new Product("Headphones", 49.99m);

            Console.WriteLine("Product 1:");
            product1.DisplayProductDetails();
            Console.WriteLine();

            Console.WriteLine("Product 2:");
            product2.DisplayProductDetails();
            Console.WriteLine();

            Console.WriteLine("Product 3:");
            product3.DisplayProductDetails();

            Console.ReadLine(); 
        }
    }

}
