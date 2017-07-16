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
    public class ProductController : Controller
    {
        private IProductRepository productRepository;        

        public ProductController()
        {
            this.productRepository = new ProductRepository();
        }

        public ActionResult Index()
        {
            ViewData.Model =  productRepository.GetAll().ToList();
            return View();
        }
    }
}