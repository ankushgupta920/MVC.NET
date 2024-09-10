using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UploadingAndRetrievingImages.Models;

namespace UploadingAndRetrievingImages.Controllers
{
    public class HomeController : Controller
    {
        NewDBEntities db = new NewDBEntities();
        // GET: Home
        public ActionResult Index()
        {
            var data = db.students.ToList();
            return View(data);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(student obj)
        {
            string fileName = Path.GetFileNameWithoutExtension(obj.ImageFile.FileName);
            string extension  = Path.GetExtension(obj.ImageFile.FileName);
            HttpPostedFileBase obj2 = obj.ImageFile;
            int length = obj2.ContentLength;

            if(extension.ToLower() == ".jpg" || extension.ToLower() == ".png" || extension.ToLower() == ".jpeg")
            {
                if (length <= 1000000)
                {
                    fileName = fileName + extension;
                    obj.image_path = "~/Images/" + fileName;

                    //This next 2 lines is for saving the file in the project:-----
                    fileName = Path.Combine(Server.MapPath("~/Images/"), fileName);
                    obj.ImageFile.SaveAs(fileName);

                    db.students.Add(obj);
                    int i = db.SaveChanges();
                    if (i > 0)
                    {
                        ViewBag.Message = "<script>alert('Record Inserted !!')</script>";
                        ModelState.Clear();
                    }
                    else
                    {
                        ViewBag.Message = "<script>alert('Record Not Inserted !!')</script>";
                    }
                }
                else
                {
                    ViewBag.SizeMessage = "<script>alert('Size Should be of 1MB !!')</script>";
                }
            }
            else
            {
                ViewBag.ExtensionMessage = "<script>alert('Image Not Supported !!')</script>";
            }

           
            return View();
        }
    }
}