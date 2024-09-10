using CookiesDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CookiesDemo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost] 
        public ActionResult Index(User obj)
        {
            if(ModelState.IsValid == true)
            {
                HttpCookie cookie = new HttpCookie("UserName");
                cookie.Value = obj.UserName;

                //This will save the cookie in browser:
                HttpContext.Response.Cookies.Add(cookie);
                // Persist:-
                cookie.Expires = DateTime.Now.AddDays(2);
                return RedirectToAction("Index","Dashboard");
            }
            return View();
        }
    }
}