using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechnicalAssesmentElinnov.Models;
using TechnicalAssesmentElinnov.Views;

namespace TechnicalAssesmentElinnov.Controllers
{
    class Program
    {
        static void Main(string[] args)
        {
            var inventoryManager = new InventoryManager();
            var view = new ConsoleView();

            while (true)
            {
                int choice = view.ShowMenu();

                try
                {
                    switch (choice)
                    {
                        case 1: // Add Product
                            var product = view.GetProductDetails();
                            inventoryManager.AddProduct(product);
                            view.DisplayMessage("Product added successfully.");
                            break;

                        case 2: // Remove Product
                            int removeId = view.GetProductId();
                            inventoryManager.RemoveProduct(removeId);
                            view.DisplayMessage("Product removed successfully.");
                            break;

                        case 3: // Update Product Quantity
                            int updateId = view.GetProductId();
                            int newQuantity = view.GetNewQuantity();
                            inventoryManager.UpdateProduct(updateId, newQuantity);
                            view.DisplayMessage("Product quantity updated successfully.");
                            break;

                        case 4: // List Products
                            var products = inventoryManager.ListProducts();
                            view.DisplayProducts(products);
                            break;

                        case 5: // Get Total Inventory Value
                            double totalValue = inventoryManager.GetTotalValue();
                            view.DisplayTotalValue(totalValue);
                            break;

                        case 6: // Exit
                            view.DisplayMessage("Exiting program. Goodbye!");
                            return;

                        default:
                            view.DisplayMessage("Invalid choice. Please select a valid option.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    view.DisplayMessage($"Error: {ex.Message}");
                }
            }
        }
    }
}
