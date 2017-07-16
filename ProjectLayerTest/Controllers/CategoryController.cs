using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjectLayerTest.Models;
using ProjectLayerTest.Models.Interface;
using ProjectLayerTest.Models.Repository;

namespace ProjectLayerTest.Controllers
{
    public class CategoryController : Controller
    {

        private ICategoryRepository categoryRepository;

        public CategoryController()
        {
            this.categoryRepository = new CategoryRepository();
        }

        public ActionResult Index()
        {
            using (NorthwindEntities db = new NorthwindEntities())
            {

                ViewData.Model = this.categoryRepository.GetAll().ToList();
                return View();
            }
        }


    }
}