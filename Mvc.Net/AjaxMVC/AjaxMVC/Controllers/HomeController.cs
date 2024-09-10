using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AjaxMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Time = DateTime.Now.ToLongTimeString();
            return View();
        }
        public ActionResult PartialUpdate()
        {
            ViewBag.Time = DateTime.Now.ToLongTimeString();
            return PartialView("_PartialUpdate");
        }
    }
}