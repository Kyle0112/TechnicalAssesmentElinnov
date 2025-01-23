using System;
using System.Collections.Generic;
using System.Globalization; // Import for culture-specific formatting
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechnicalAssesmentElinnov.Models;

namespace TechnicalAssesmentElinnov.Views
{
    public class ConsoleView
    {
        public int ShowMenu()
        {
            Console.WriteLine("\nInventory Management System");
            Console.WriteLine("1. Add Product");
            Console.WriteLine("2. Remove Product");
            Console.WriteLine("3. Update Product Quantity");
            Console.WriteLine("4. List Products");
            Console.WriteLine("5. Get Total Inventory Value");
            Console.WriteLine("6. Exit");
            Console.Write("Enter your choice: ");
            return int.TryParse(Console.ReadLine(), out int choice) ? choice : -1;
        }

        public Product GetProductDetails()
        {
            Console.Write("Enter Product ID: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Enter Product Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Quantity in Stock: ");
            int quantity = int.Parse(Console.ReadLine());

            Console.Write("Enter Product Price: ");
            double price = double.Parse(Console.ReadLine());

            return new Product { ProductId = id, Name = name, QuantityInStock = quantity, Price = price };
        }

        public int GetProductId()
        {
            Console.Write("Enter Product ID: ");
            return int.Parse(Console.ReadLine());
        }

        public int GetNewQuantity()
        {
            Console.Write("Enter New Quantity: ");
            return int.Parse(Console.ReadLine());
        }

        public void DisplayProducts(List<Product> products)
        {
            if (products.Count == 0)
            {
                Console.WriteLine("Inventory is empty.");
                return;
            }

            Console.WriteLine("\nCurrent Inventory:");
            foreach (var product in products)
            {
                
                Console.WriteLine($"ID: {product.ProductId}, Name: {product.Name}, Quantity: {product.QuantityInStock}, Price: {product.Price.ToString("C", CultureInfo.GetCultureInfo("en-US"))}");
            }
        }

        public void DisplayTotalValue(double totalValue)
        {
            
            Console.WriteLine($"\nTotal Inventory Value: {totalValue.ToString("C", CultureInfo.GetCultureInfo("en-US"))}");
        }

        public void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
