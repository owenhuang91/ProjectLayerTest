using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjectLayerTest.Models;

namespace ProjectLayerTest.Controllers
{
    public class ProductController : Controller
    {
        private NorthwindEntities db = new NorthwindEntities();

        public ActionResult Index()
        {
            var products = db.Products.OrderByDescending(x => x.ProductID);
            ViewData.Model = products.ToList();
            return View();
        }
    }
}