using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using u20676736_HW06.Models;
using PagedList;
using u20676736_HW06.Models.ViewModel;

namespace u20676736_HW06.Controllers
{    
    public class HomeController : Controller
    {
        public BikeStoresEntities db = new BikeStoresEntities();
        public ActionResult Index()
        {
            //var list = db.products.Select(x=> new CustomProduct { productName= x.product_name, brandName=x.brand.brand_name}).ToList();
            return View();
        }

        public ActionResult About(string currentFilter, string searchString, int? page)
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}