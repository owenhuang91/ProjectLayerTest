using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjectLayerTest.Models;

namespace ProjectLayerTest.Controllers
{
    public class CategoryController : Controller
    {
        public ActionResult Index()
        {
            using (NorthwindEntities db = new NorthwindEntities())
            {
                var query = db.Categories.OrderBy(x => x.CategoryID);
                ViewData.Model = query.ToList();
                return View();
            }
        }
    }
}