using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MatrixChallenge.Models
{
    public class Rectangle
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public int Area()
        {
            var total = 0;
            total = Width * Height;
            return total;
        }
    }
    public static class RectangleStatic 
    {
        public static int Width { get; set; }
        public static int Height { get; set; }

        public static int Area()
        {
            var total = 0;
            total = Width * Height;

            return total;
        }
    }
}