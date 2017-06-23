using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeABouquet.Models
{
    public class Bouquet
    {
        public List<Flower> BouquetBundle { get; set; }

        public Bouquet()
        {
            BouquetBundle = new List<Flower>();
        }
    }
}