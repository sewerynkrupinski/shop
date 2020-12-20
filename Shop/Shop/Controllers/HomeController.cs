using Shop.DAL;
using Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Shop.Controllers
{
    public class HomeController : Controller
    {
        private ShopContext db = new ShopContext();

        public ActionResult Index()
        {
            Category category = new Category
            {
                CategoryName = "asp.net mvc",
                IconFileName = "aspNetMvc.png",
                CategoryDescription = "description"
            };
            db.Categories.Add(category);
            db.SaveChanges();

            return View();
        }
    }
}