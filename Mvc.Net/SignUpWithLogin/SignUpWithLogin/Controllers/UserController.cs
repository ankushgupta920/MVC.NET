using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SignUpWithLogin.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            if (Session["UserId"] == null)
            {
                return RedirectToAction("Index","Login");
            }
            else
            {
                return View();
            } 
        }
        public ActionResult LogOut()
        {
            if(Session["UserId"] != null)
            {
                Session.Abandon();
                return RedirectToAction("Index", "Login");
            }
            else
            {
                return View();
            }
        }
    }
}