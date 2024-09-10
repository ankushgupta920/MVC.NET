using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Employee emp1 = new Employee();
            emp1.Id = 11;
            emp1.Name = "Ankush";
            emp1.Age = 20;

            Employee emp2 = new Employee();
            emp2.Id = 12;
            emp2.Name = "Harsh";
            emp2.Age = 21;


            Employee emp3 = new Employee();
            emp3.Id = 13;
            emp3.Name = "Ujjwal";
            emp3.Age = 25;

            List<Employee> EmployeeLists = new List<Employee>();
            EmployeeLists.Add(emp1); 
            EmployeeLists.Add(emp2);
            EmployeeLists.Add(emp3);

            ViewData["Var1"] = emp1;
            ViewBag.Var2 = emp1;
            return View(EmployeeLists);
        }
        public ActionResult Index2()
        {
            return View();
        }

        public ActionResult Index3()
        {
            return View();
        }
    }
}