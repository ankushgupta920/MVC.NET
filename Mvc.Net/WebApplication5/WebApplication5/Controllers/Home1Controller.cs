using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication5.Models;

namespace WebApplication5.Controllers
{
    public class Home1Controller : Controller
    {
        // GET: Home1
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Calculation c)
        {
            int num1 = c.Num1;
            int num2 = c.Num2;
            int result = num1 + num2;

            ViewBag.result = result;
            return View();
        }
    } 
}