
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CalculateTheMatrix.Models
{
    public class NumEntryViewModel
    {
        public List<Matrix> Matrices { get; set; }

        public NumEntryViewModel()
        {
            Matrices = new List<Matrix>();
        }

        public string Calc { get; set; }
    }
}