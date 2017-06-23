using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls.WebParts;

namespace SimplyFloral.Models
{
    public class Bouquet
    {
        public List<VarietyViewModel> FinalProduct { get; set; }

        public Bouquet()
        {
            FinalProduct = new List<VarietyViewModel>();
        }

    }
}