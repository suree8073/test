using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using test.DataContext;
using test.Entitites;

namespace test.Controllers
{
    public class CustomerOrderController : Controller
    {
        // GET: CustomerOrder  
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult CustomersList()
        {
            return View();
        }

        [HttpGet]
        public ActionResult GetCustomers()
        {
            using (DashboardContext _context = new DashboardContext())
            {
                var testUser1 = new Customer
                {
                    ID = 1,
                    CustomerName = "Luke",
                    CustomerEmail = "Skywalker@gmail.com",
                    CustomerImage = "",
                    CustomerCountry="Thai",
                    CustomerPhone="083546974126"
                };

                List<Customer> lstCus = new List<Customer>();

                lstCus.Add(testUser1);

                var testUser2 = new Customer
                {
                    ID = 2,
                    CustomerName = "test",
                    CustomerEmail = "test@gmail.com",
                    CustomerImage = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fen.wikipedia.org%2Fwiki%2FImage&psig=AOvVaw3udvkBFljPaChDc4ye_zsk&ust=1634785188208000&source=images&cd=vfe&ved=0CAsQjRxqFwoTCPDyh8z-1_MCFQAAAAAdAAAAABAD",
                    CustomerCountry = "Thai",
                    CustomerPhone = "083546974126"
                };
                lstCus.Add(testUser2);
                //_context.SaveChanges();

                //var customerList = _context.CustomerSet.Select(c => new
                //{
                //    c.ID,
                //    c.CustomerName,
                //    c.CustomerEmail,
                //    c.CustomerPhone,
                //    c.CustomerCountry,
                //    c.CustomerImage
                //}).ToList();

                return Json(new { data = lstCus }, JsonRequestBehavior.AllowGet);
            }


        }
    }
}