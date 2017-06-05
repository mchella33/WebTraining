using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OneMoreTime.Controllers
{
    public class HOmeController : Controller
    {
        // GET: HOme
        public ActionResult Index()
        {
            return View();
        }
    }
}