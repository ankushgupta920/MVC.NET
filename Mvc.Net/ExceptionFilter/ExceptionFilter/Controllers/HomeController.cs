﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExceptionFilter.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [HandleError]
        public ActionResult Index()
        {
            throw new Exception();
            return View();
        }
    }
}