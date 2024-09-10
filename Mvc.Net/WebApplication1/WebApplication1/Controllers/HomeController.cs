using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index()
        {
            //ViewData:
            //ViewData["Message"] = "Message from View Data !!";
            //ViewData["CurrentTime"] = DateTime.Now.ToLongTimeString();
            //string[] Fruits = { "Apple", "banana", "Grapes", "Orange" };
            //ViewData["FruitsArray"] = Fruits;
            //ViewData["SportsList"] = new List<string>()
            //{
            //    "Cricket",
            //    "Hockey",
            //    "Football",
            //    "Volley Ball"
            //};

            //Employee Ali = new Employee();
            //Ali.EmpID = 11;
            //Ali.EmpName = "Ali Khan";
            //Ali.EmpDesignation = "Manager";

            //ViewData["Employee"] = Ali;

            //ViewBag
            //ViewBag.Message = "Message from View Bag !!";
            //ViewBag.CurrentDate = DateTime.Now.ToLongDateString();
            //String[] Fruits = { "Apple", "banana", "Grapes", "Orange" };
            //ViewBag.FruitsArray = Fruits;
            //ViewBag.SportsList = new List<string>()
            //{
            //        "Cricket",
            //        "Hockey",
            //        "Football",
            //        "Volley Ball"
            //};
            //Employee Ali = new Employee();
            //Ali.EmpName = "Ali Khan";
            //Ali.EmpID = 1;
            //Ali.EmpDesignation = "Manager";
            //ViewBag.Employee = Ali;

            //ViewBag.CommonMessage = "This msg is accessible by both ViewBag and ViewData";


            //TempData
            TempData["Message1"] = "Message from Temp Data !!";
            String[] Fruits = { "Apple", "banana", "Grapes", "Orange" };
            TempData["FruitsArray"] = Fruits;
            ViewData["Message2"] = "Message from View Data !!";
            ViewBag.Message3 = "Message from View Bag !!";
            //return RedirectToAction("AboutUs");
            return View();
        }

        //public string Show()
        //{
        //    return "This is my second action method of home controller";
        //}

        public ActionResult AboutUs()
        {
            TempData.Keep();
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
        //public int StudentID (int id)
        //{
        //    return id;
        //}
    }
}