using SignUpWithLogin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SignUpWithLogin.Controllers
{
    public class LoginController : Controller
    {
        SignUpLoginEntities db = new SignUpLoginEntities();
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(User obj)
        {
            var row = db.Users.Where(model => model.UserName == obj.UserName &&  model.Password == obj.Password).FirstOrDefault();
            if(row != null)
            {
                Session["UserId"] = row.Id.ToString();
                Session["Username"] = row.UserName.ToString();
                TempData["LoginSuccessMsg"] = "<script>alert('LogIN Successfully !!')</script>";
                return RedirectToAction("Index", "User");
            }
            else
            {
                ViewBag.ErrorMessage = "<script>alert('UserName or Password is Incorrect !!')</script>";
                return View();
            }
            
        }
        public ActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SignUp(User obj)
        {
            if(ModelState.IsValid == true)
            {
                db.Users.Add(obj);
                int i = db.SaveChanges();
                if(i > 0)
                {
                    ViewBag.InsertMsg = "<script>alert('Registered Successfully')</script>";
                    ModelState.Clear();
                }
                else
                {
                    ViewBag.InsertMsg = "<script>alert('Registeration Failed')</script>";
                }
            }
            return View();
        }
    }
}