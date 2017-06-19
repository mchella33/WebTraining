using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MatrixCalculatorHW.Models
{
    public class NumEntryViewModel
    {
        public List<Matrix> Matrices { get; set; }

        public NumEntryViewModel()
        {
            Matrices = new List<Matrix>();
        }
    }
}