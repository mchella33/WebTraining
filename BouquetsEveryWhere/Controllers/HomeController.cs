using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BouquetsEveryWhere.Models;

namespace BouquetsEveryWhere.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var model = new NumberOfTypes();
            return View();
        }

        public ActionResult MakeSelection(NumberOfTypes input)
        {

            return View();
        }

        public ActionResult ChooseType(ChooseType input)
        {
            return View();
        }
        public ActionResult CreateBouquet()
        {
            return View();
        }
    }
}