using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MatrixCalculatorHW.Models
{
    public class IndexViewModel
    {
        [Required(ErrorMessage = "Please enter a number")]
        public int Columns { get; set; }
        [Required(ErrorMessage = "Please enter a number")]
        public int Rows { get; set; }   
    }
}