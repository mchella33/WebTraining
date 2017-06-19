using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace MatrixCalculatorHW.Models
{
    public class Matrix
    {
        public int [][] Mesh { get; set; }

        public Matrix()
        {
            
        }

        public Matrix(int columns, int rows)
        {
            Mesh = new int[columns][];
            for (int i = 0; i < columns; i++)
            {
                Mesh[i] = new int[rows];
            }
        }

        public Matrix Add(Matrix input)
        {
            for (int i = 0; i < input.Mesh.Length; i++)
            {
                for (int j = 0; j < input.Mesh[i].Length; j++)
                {
                    this.Mesh[i][j] += input.Mesh[i][j];
                }
            }
            return this;
        }

    }
}