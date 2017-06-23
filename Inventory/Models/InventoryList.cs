using Inventory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Schema;

namespace Inventory.Models
{
    public class InventoryList
    {
        public List<Product> Inventory { get; set; }

        public InventoryList()
        {
            Inventory = new List<Product>();
           
        }
    }
}