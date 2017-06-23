using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OneMoreTimeIMeanIt.Models;

namespace OneMoreTimeIMeanIt.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Obituary()
        {
            return View();
        }

        public ActionResult SubmitStory(StoryViewModel input)
        {
            var model = new StoryViewModel();
            return View(model);
        }

        public ActionResult Story(StoryListViewModel input)
        {
            var model = new StoryListViewModel();
            model.Stories.Add(new Story());   
            return View(model);
        }
    }
}