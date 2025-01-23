using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalAssesmentElinnov.Models
{

    public class Product
    {
        public int ProductId { get; set; } // Unique ID
        public string Name { get; set; }  // Product Name
        public int QuantityInStock { get; set; } // Quantity
        public double Price { get; set; } // Price per unit

        public string PriceInUSD => Price.ToString("C", CultureInfo.GetCultureInfo("en-US"));
    }
}
