using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using MakeMeABouquet.Models;

namespace MakeMeABouquet.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var model = new NumberOfFlowers();
            return View();
        }

        public ActionResult CreateBouqet(Flower input)
        {
            var model = new NumberOfFlowers();
            

            return View();
        }

        public ActionResult FinalProduct(Flower input)
        {
            var model = new Bouquet();
            model.BouquetBundle.Add(new Flower(input.Name, input.Quantity));
            return View(model);
        }
    }
}