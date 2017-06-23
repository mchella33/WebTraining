using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ClassCreation.Models;

namespace ClassCreation.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var deck = new Deck();

            return View(deck);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}