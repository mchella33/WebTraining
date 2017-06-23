using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CalculatorOfTheMatrix.Models
{
    public class InputEntryViewModel
    {
        public int Rows { get; set; }
        public int Columns { get; set; }
        public List<Matrix> Grid { get; set; }

    }
}