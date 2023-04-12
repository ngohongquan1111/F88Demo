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
            List<Customer> customers = new List<Customer>();

            for (int i = 0; i < 50; i++)
            {
                customers.Add(new Customer { CustomerId = 0, CustomerName = $"Customer number: {i + 1}" });
            }

            using (var dbContext = new MvcDemoDbContext())
            {
                var abc = dbContext.Customers.Where(c => c.CustomerId > 0).ToList();

                var customer = new Customer { CustomerName = $"Customer number: 1" };

                dbContext.Customers.Add(customer);

                dbContext.SaveChanges();
            }

            return View();
        }
    }
}