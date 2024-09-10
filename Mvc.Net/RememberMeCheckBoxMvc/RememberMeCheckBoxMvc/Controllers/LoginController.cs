using RememberMeCheckBoxMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace RememberMeCheckBoxMvc.Controllers
{
    public class LoginController : Controller
    {
        LoginDBEntities db = new LoginDBEntities();
        // GET: Login
        public ActionResult Index()
        {
            HttpCookie cookie = Request.Cookies["User"];
            if(cookie != null)
            {
                ViewBag.username = cookie["UserName"].ToString();
                ViewBag.password = cookie["Password"].ToString();
            }
            return View();
        }
        [HttpPost]
        public ActionResult Index(User obj)
        {
            HttpCookie cookie = new HttpCookie("User");
            if (ModelState.IsValid == true)
            {
                if(obj.RememberMe == true)
                {
                    cookie["UserName"] = obj.username;
                    cookie["Password"] = obj.password;
                    cookie.Expires = DateTime.Now.AddDays(2);
                    HttpContext.Response.Cookies.Add(cookie);
                }
                else
                {
                    cookie.Expires = DateTime.Now.AddDays(-1);
                    HttpContext.Response.Cookies.Add(cookie);
                }
                var row = db.Users.Where(model => model.username == obj.username &&  model.password == obj.password).FirstOrDefault();
                if(row != null)
                {
                    Session["UserName"] = obj.username;
                    TempData["Message"] = "<script>alert('Login Successfull !!')</script>";
                    return RedirectToAction("Index","Dashboard");
                }
                else
                {
                    TempData["Message"] = "<script>alert('Login Failed !!')</script>";
                }

            }
            return View();
        }
    }
}