using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using CalculatorOfTheMatrix.Models;

namespace CalculatorOfTheMatrix.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index(RolColViewModel model)
        {
            
            
            return View(model);
        }

        public ActionResult InputGrid(InputEntryViewModel input)
        {
            var model = new InputEntryViewModel();
            model.Grid = new ;
           
            
            return View(model);
        }

        public ActionResult Sum()
        {
            return View();
        }
    }
}