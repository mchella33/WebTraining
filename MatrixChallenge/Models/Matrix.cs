using System;
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

        public Matrix(int r, int c)
        {
            this.Rows = r;
            this.Columns = c;
        }

        public Matrix Add(Matrix matrix2)
        {
            
            var sum = new Matrix(matrix2.Rows, matrix2.Columns);
            return sum;
        }
    }
}