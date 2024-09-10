using LoginFormMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoginFormMVC.Controllers
{
    public class LoginController : Controller
    {
        LoginDBEntities db = new LoginDBEntities();
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(User obj)
        {
            if(ModelState.IsValid == true)
            {
                var credentials = db.Users.Where(model => model.UserName == obj.UserName && model.Password == obj.Password).FirstOrDefault();
                if (credentials == null)
                {
                    ViewBag.ErrorMsg = "LOGIN FAILED";
                    return View();
                }
                else
                {
                    Session["UserName"] = obj.UserName;
                    return RedirectToAction("Index","Home");
                }
            }
            return View();

        }
        public ActionResult logout()
        {
            Session.Abandon();
            return RedirectToAction("Index","Login");
        }
        public ActionResult Reset()
        {
            ModelState.Clear();
            return RedirectToAction("Index", "Login");
        }

    }
}