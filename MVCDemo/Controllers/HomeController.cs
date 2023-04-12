using MVCDemo.Service.DataBaseContext;
using MVCDemo.Service.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            List<Customer> customers = new List<Customer>();

            for (int i = 0; i < 50; i++)
            {
                customers.Add(new Customer { CustomerName = $"Customer number: {i+1}" });
            }

            using (var dbContext = new MvcDemoDbContext())
            {
                //dbContext.Customers.AddRange(customers);
                var abc = dbContext.Customers.Where(c => c.CustomerId > 0).ToList();
                dbContext.Customers.Add(new Customer { CustomerName = $"Customer number: 1" });
                dbContext.SaveChanges();
            }

                return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}