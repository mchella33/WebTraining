using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Inventory.Models
{
    public class Product
    {
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public int Quantity { get; set; }

        public Product()
        {
            
        }
        public Product(string productName, decimal productPrice, int quantity)
        {
            ProductName = productName;
            ProductPrice = productPrice;
            Quantity = quantity;

        }
    }
}