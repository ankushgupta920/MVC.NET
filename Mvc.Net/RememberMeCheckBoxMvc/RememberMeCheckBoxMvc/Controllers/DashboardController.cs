using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RememberMeCheckBoxMvc.Controllers
{
    public class DashboardController : Controller
    {
        // GET: Dashboard
        public ActionResult Index()
        {
            if(Session["UserName"] == null)
            {
                return RedirectToAction("Index","Login");
            }
            else
            {
                return View();
            }
    
        }
        public ActionResult Logout()
        {
            if(Session["UserName"] != null)
            {
                Session.Abandon();
                return RedirectToAction("Index", "Login");
            }
            return View();
        }
    }
}