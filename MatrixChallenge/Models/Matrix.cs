using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace MatrixChallenge.Models
{
    public class Matrix 
    {
        
        public int Rows { get; set; }
        public int Columns { get; set; }
        
        public Array Cells { get; set; }

        public Matrix(int r, int c)
        {
            this.Rows = r;
            this.Columns = c;
            this.Cells = new decimal[r, c];
        }

        public Matrix()
        {
            
        }

        public Matrix Add(Matrix matrix2)
        {
            
            var sum = new Matrix(matrix2.Rows, matrix2.Columns);
            return sum;
        }

        //if you were to use lists this is a way to do that
        //private void GenerateCells()
        //{
        //    var list = new List<cell>();
        //    for (var i = 0; i < this.Rows; i++)
        //    {
        //        for (var j = 0; j < this.Columns; j++)
        //        {
        //            var cell = new cell(i,j);
        //            list.Add(cell);
        //        }
        //    }
        //    this.cells = list;
        //}
      
    }

    public class cell
    {
        public cell(int x, int y)
        {
            this.Xval = x;
            this.Yval = y;
        }
        public double Value { get; set; }
        public int Xval { get; set; }
        public int Yval { get; set; }
    }
}