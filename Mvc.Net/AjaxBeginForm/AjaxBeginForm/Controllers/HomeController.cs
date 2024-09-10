using AjaxBeginForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AjaxBeginForm.Controllers
{
    public class HomeController : Controller
    {
        EmployeeDBEntities db = new EmployeeDBEntities();
        // GET: Home
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Table obj)
        {
            if (ModelState.IsValid == true)
            {
                db.Tables.Add(obj);
                int i = db.SaveChanges();
                if (i > 0)
                {
                    return Json("Data Inserted!!!!");
                }
                else
                {
                    return Json("Data Not Inserted!!!");
                }

            }
            return View();
        }
    }
}