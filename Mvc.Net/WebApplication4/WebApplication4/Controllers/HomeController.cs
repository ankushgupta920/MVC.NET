using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home

        List<Product> ProductsList = new List<Product>()
        {
            new Product{Id = 1, Name = "Reebok Shoes", Price = 10000.00, Picture = "~/Images/shoe-photo-editing-after(1).jpg"},
            new Product{Id = 2, Name = "Reyben  Sunglasses", Price = 1000.00, Picture = "~/Images/pngtree-black-round-sunglasses-image_1161416.jpg"},
            new Product{Id = 3, Name = "Rolex Watch", Price = 10000.00, Picture = "~/Images/1df8f83e1c6ae8a265a6dea3e985a796.jpg"}
        };
        public ActionResult Index()
        {
            return View(ProductsList);
        }
    }
}