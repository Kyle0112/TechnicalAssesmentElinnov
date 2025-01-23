using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalAssesmentElinnov.Models
{
    public class InventoryManager
    {
        private readonly List<Product> _inventory = new List<Product>();

        public void AddProduct(Product product)
        {
            if (_inventory.Any(p => p.ProductId == product.ProductId))
            {
                throw new InvalidOperationException("A product with this ID already exists.");
            }
            _inventory.Add(product);
        }

        public void RemoveProduct(int productId)
        {
            var product = _inventory.FirstOrDefault(p => p.ProductId == productId);
            if (product == null)
            {
                throw new KeyNotFoundException("Product not found.");
            }
            _inventory.Remove(product);
        }

        public void UpdateProduct(int productId, int newQuantity)
        {
            var product = _inventory.FirstOrDefault(p => p.ProductId == productId);
            if (product == null)
            {
                throw new KeyNotFoundException("Product not found.");
            }
            product.QuantityInStock = newQuantity;
        }

        public List<Product> ListProducts()
        {
            return _inventory;
        }

        public double GetTotalValue()
        {
            return _inventory.Sum(p => p.QuantityInStock * p.Price);
        }

        public string GetFormattedTotalValue()
        {
            double totalValue = GetTotalValue();
            return totalValue.ToString("C", CultureInfo.GetCultureInfo("en-US"));
        }
    }
}
