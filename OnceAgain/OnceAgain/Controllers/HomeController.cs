using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnceAgain.Models;

namespace OnceAgain.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var model = new StoriesViewModel();
            return View(model);
        }
    }
}