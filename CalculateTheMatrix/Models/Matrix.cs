using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace CalculateTheMatrix.Models
{
    public class Matrix
    {
        public int [][] Grid { get; set; }

        public Matrix()
        {
            
        }

        public Matrix(int columns, int rows)
        {
            Grid = new int[columns][];
            for (int i = 0; i < columns; i++)
            {
                Grid[i] = new int[rows];
            }
        }

        public Matrix Add(Matrix input)
        {
            
            for (int i = 0; i < input.Grid.Length; i++)
            {
                for (int j = 0; j < input.Grid[i].Length; j++)
                {
                    this.Grid[i][j] += input.Grid[i][j];
                }
            }
            return this;
        }
        public Matrix Muliply(Matrix input)
        {

            for (int i = 0; i < input.Grid.Length; i++)
            {
                for (int j = 0; j < input.Grid[i].Length; j++)
                {
                    this.Grid[i][j] *= input.Grid[i][j];
                }
            }
            return this;
        }


    }
}