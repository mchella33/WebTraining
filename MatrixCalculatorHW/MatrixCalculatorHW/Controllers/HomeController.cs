using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MatrixCalculatorHW.Models;

namespace MatrixCalculatorHW.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var model = new IndexViewModel();
            return View(model);
        }

        public ActionResult NumEntry(IndexViewModel input)
        {
            var model = new NumEntryViewModel();
            model.Matrices.Add(new Matrix(input.Columns,input.Rows));
            model.Matrices.Add(new Matrix(input.Columns, input.Rows));
            return View(model);
        }

        public ActionResult Results(NumEntryViewModel input)
        {
            var sum = input.Matrices[0];
            for (int i = 1; i < input.Matrices.Count; i++)
            {
                sum.Add(input.Matrices[i]);
            }

            return View(sum);
        }
    }
}