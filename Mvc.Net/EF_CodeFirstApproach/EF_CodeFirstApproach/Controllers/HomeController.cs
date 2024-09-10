using EF_CodeFirstApproach.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EF_CodeFirstApproach.Controllers
{
    public class HomeController : Controller
    {
        StudentContext db = new StudentContext();
        // GET: Home
        public ActionResult Index()
        {
            var data = db.Students.ToList();
            return View(data);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost] 
        public ActionResult Create(Student s)
        {
            if (ModelState.IsValid == true)
            {
                db.Students.Add(s);
                int a = db.SaveChanges();   
                if (a > 0)
                {
                    TempData["InsertMsg"] = "<script>alert('Data Inserted !!')</script>";
                    return RedirectToAction("Index");
                }
                else
                {
                    ViewBag.InsertMsg = "<script>alert('Data Not Inserted !!')</script>";
                }
            }
            return View();
        }
        public ActionResult Edit(int id)
        {
            var row = db.Students.Where(model => model.ID == id).FirstOrDefault();
            return View(row);
        }
        [HttpPost]
        public ActionResult Edit(Student s)
        {
            db.Entry(s).State = EntityState.Modified;
            int a = db.SaveChanges();
            if (a > 0)
            {
                TempData["UpdateMsg"] = "<script>alert('Data Updated !!')</script>";
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.UpdateMsg = "<script>alert('Data Not Updated !!')</script>";
            }
            return View();
        }
        public ActionResult Delete(int Id)
        {
            if(Id > 0)
            {
                var row = db.Students.Where(model => model.ID == Id).FirstOrDefault();
                if(row != null)
                {
                    db.Entry(row).State = EntityState.Deleted;
                    int a = db.SaveChanges();
                    if (a > 0)
                    {
                        TempData["DeleteMsg"] = "<script>alert('Data Deleted !!')</script>";
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        ViewBag.DeleteMsg = "<script>alert('Data Not Deleted !!')</script>";
                    }
                }
            }
            return RedirectToAction("Index");   
        }
        public ActionResult Details(int Id)
        {
            var row = db.Students.Where(model => model.ID != Id).FirstOrDefault();
            return View(row);
        }


    }
}