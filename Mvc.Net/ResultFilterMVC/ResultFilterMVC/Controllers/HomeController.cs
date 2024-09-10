using ResultFilterMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ResultFilterMVC.Controllers
{
    public class HomeController : Controller
    {
        PersonDBEntities db = new PersonDBEntities();
        // GET: Home
        [OutputCache(Duration = 10)]
        public ActionResult Index()
        {
            ViewBag.Time = DateTime.Now.ToLongTimeString();
            return View();
        }
        [OutputCache(Duration = 40,Location = System.Web.UI.OutputCacheLocation.Any)]
        public ActionResult GetData()
        {
            var Data = db.People.ToList();
            return View(Data);
        }
    }
}