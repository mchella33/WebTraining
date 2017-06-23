using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeABouquet.Models
{
    public class Flower
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        


        public Flower()
        {
            
        }

        public Flower(string name, int quantity)
        {
            Name = name;
            Quantity = quantity;
            
        }
    }
}