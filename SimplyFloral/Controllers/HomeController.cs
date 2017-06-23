using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SimplyFloral.Models;

namespace SimplyFloral.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var model = new SizeViewModel();
            return View();
        }

        public ActionResult ChooseVariety(SizeViewModel input)
        {
            var model = new VarietyViewModel();
            
            return View();

        }

        public ActionResult FinalProduct()
        {
            return View();
        }
    }
}