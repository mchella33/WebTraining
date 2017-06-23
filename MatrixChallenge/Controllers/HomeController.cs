using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls.WebParts;
using MatrixChallenge.Models;

namespace MatrixChallenge.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var rectangle = new Rectangle();
            rectangle.Width = 2;
            rectangle.Height = 3;
            var area = rectangle.Area();// 6

            RectangleStatic.Width = 4;
            RectangleStatic.Height = 8;
            var area2 =  RectangleStatic.Area();// 32

            var square = new Rectangle();
            square.Width = 4;
            square.Height = 4;
            var squareArea = square.Area();// 16

            RectangleStatic.Width = 5;
            RectangleStatic.Height = 5;
            area2 = RectangleStatic.Area();// 25

            area = rectangle.Area();// 6
            return View();
        }

        public ActionResult NumEntry(Matrix rowColInput)
        {
            var model = new MatrixViewModel();
            model.Matrix1 = new Matrix(rowColInput.Rows, rowColInput.Columns);
            model.Matrix2 = new Matrix(rowColInput.Rows, rowColInput.Columns);
            return View(model);
        }

        public ActionResult AddMatrices(MatrixViewModel model)
        {
            //stupid way
            //var m1 = new Array[model.Matrix1.Rows,model.Matrix1.Columns];
            //for (int i = 0; i < model.Matrix1.Rows; i++)
            //{
            //    for (int j = 0; j < model.Matrix1.Columns; j++)
            //    {
            //        var m1Value = Request[$"Matrix1-{i}-{j}"];
            //        var m2Value = Request[$"Matrix2-{i}-{j}"];
            //    }
            //}
            return View();
        }
        public ActionResult Calculate()
        {
            
            return View();
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