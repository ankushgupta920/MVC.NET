using AuthorizeAndAuthenticationMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using System.Web.UI.WebControls;
using Table = AuthorizeAndAuthenticationMVC.Models.Table;

namespace AuthorizeAndAuthenticationMVC.Controllers
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
        public ActionResult Index(Table obj, string ReturnUrl)
        {
            if(IsValid(obj) == true)
            {
                FormsAuthentication.SetAuthCookie(obj.username, false);
                Session["Username"] = obj.username.ToString();
                if (ReturnUrl != null)
                {
                    return Redirect(ReturnUrl);
                }
                else
                {
                    return RedirectToAction("Index","Home");
                }
            }
            else
            {
                return View();
            }        
        }
        public bool IsValid(Table obj)
        {
            var row = db.Tables.Where(model => model.username == obj.username && model.password == obj.password).FirstOrDefault();
            if (row != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            Session["Username"] = null;
            return RedirectToAction("index", "Home");
        }
    }
}