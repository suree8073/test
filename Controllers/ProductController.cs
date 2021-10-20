using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using test.Models;

namespace test.Controllers
{
    public class ProductController : Controller
    {
        OnlineShopEntities2 db = new OnlineShopEntities2();
        // GET: Product
        public ActionResult AddNewProduct()
        {
            return View(db.tblProduct.ToList());
        }

        [HttpPost]
        public ActionResult GetDetails(int productId)
        {
            var result = db.tblProduct.FirstOrDefault(p => p.ProductId == productId);//.ToList();

            return PartialView(result);

        }

  
    }
}