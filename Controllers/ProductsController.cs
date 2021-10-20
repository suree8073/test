using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using test.Models;

namespace test.Controllers
{
    public class ProductsController : Controller
    {
        public static List<ProductsViewModel> productList = new List<ProductsViewModel>();

        // GET: Products
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult ProductList(int id)
        {
            Session["CustomerId"] = id;

            return View();
        }

      
    }
}