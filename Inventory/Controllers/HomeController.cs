using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.Mvc;
using Inventory.Models;

namespace Inventory.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var model = new Product();
            return View();
        }

        public ActionResult ProductList(Product input)
        {
           
                var model = new InventoryList();
                model.Inventory.Add(new Product(input.ProductName, input.ProductPrice, input.Quantity));
                return View(model);
        }

        [HttpPost]
        public ActionResult SubmitList(ListViewModel model)
        {
            var items = model;
            return Json(model, JsonRequestBehavior.AllowGet);
        }
    }

    public class ListViewModel
    {
       public List<ProductItem> List { get; set; }
    }
    public class ProductItem
    {
        public int ItemID  { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}