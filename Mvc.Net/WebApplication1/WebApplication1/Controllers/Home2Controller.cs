using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class Home2Controller : Controller
    {
        // GET: Home2
        public ActionResult Index()
        {
            ViewData["Var1"] = "Data comes from ViewData";
            ViewBag.Var2 = "Data comes from ViewBag";
            TempData["Var3"] = "Data comes from TempData";
            Session["Var4"] = "Data comes from Session";

            string[] Student = { "Ali", "Ankush", "Ram", "Aman" };
            Session["Var5"] = Student;

            return View();
        }

        public ActionResult About()
        {
            if(Session["Var4"] != null)
            {
                Session["Var4"].ToString().Trim();
            }
            return View();
        }

        public ActionResult Contact()
        {
            if (Session["Var4"] != null)
            {
                Session["Var4"].ToString().Trim();
            }
            return View();
        }
    }
}