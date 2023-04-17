using MVCDemo.DataBaseContext.Entity;
using MVCDemo.Models;
using MVCDemo.Services.LoanServices.AddLoan;
using System.Collections.Generic;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly AddLoanServiceHandler _addLoanServiceHandler;

        public HomeController(AddLoanServiceHandler addLoanServiceHandler)
        {
            _addLoanServiceHandler = addLoanServiceHandler;
        }


        //public HomeController(AddLoanServiceHandler addLoanServiceHandler)
        //{
        //    this._addLoanServiceHandler = addLoanServiceHandler;
        //}

        public ActionResult Index()
        {
            List<Customer> customers = new List<Customer>();

            for (int i = 0; i < 50; i++)
            {
                customers.Add(new Customer { CustomerId = 0, CustomerName = $"Customer number: {i + 1}" });
            }

            //using (var dbContext = new MvcDemoDbContext())
            //{
            //    //var abc = dbContext.Customers.Where(c => c.CustomerId > 0).ToList();

            //    //var customer = new Customer { CustomerName = $"Customer number: 1" };

            //    dbContext.Customer.AddRange(customers);

            //    dbContext.SaveChanges();
            //}

            AddLoanApplication();
            return View();
        }

        public ActionResult AddLoanApplication()
        {
            var loanApplicationDemo = new LoanApplicationModel()
            {
                Amount = 10000,
                CustomerId = 1,
                LoanStatus = 1
            };

            testDI.DoSomething();

            return View();
        }
    }
}