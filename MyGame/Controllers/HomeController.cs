using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyGame.Models;

namespace MyGame.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var deck = new Deck();
            return View(deck);
        }

        public ActionResult DisplayDeck()
        {
            return View();
        }
    }
}