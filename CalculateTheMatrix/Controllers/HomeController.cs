
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CalculateTheMatrix.Models;

namespace CalculateTheMatrix.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var model = new RolColViewModel();
            return View(model);
        }

        public ActionResult NumEntry(RolColViewModel input)
        {
            var model = new NumEntryViewModel();
            model.Matrices.Add(new Matrix(input.Columns, input.Rows));
            model.Matrices.Add(new Matrix(input.Columns, input.Rows));
            return View(model);
        }

        public ActionResult Answer(NumEntryViewModel input)
        {
            if (input.Calc == "add")
            {
                var sum = input.Matrices[0];
                for (int i = 1; i < input.Matrices.Count; i++)
                {

                    sum.Add(input.Matrices[i]);
                }
                return View(sum);

            }
            else if(input.Calc == "multiply")
            {
                var firstMatrix = input.Matrices[0];
                for (int i = 1; i < input.Matrices.Count; i++)
                {
                    firstMatrix.Muliply(input.Matrices[i]);
                }
                return View(firstMatrix);
            }
            return View();

        }
        


    }

}
