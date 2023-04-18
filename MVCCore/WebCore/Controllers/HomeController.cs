using BaseServiceHandler.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVCDemo.BaseServiceHandler;
using MVCDemo.DataBaseContext.Entity;
using MVCDemo.Service.DataBaseContext;
using MVCDemo.Services.LoanServices.AddLoan;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebCore.Models;
using WebCore.Services.LoanService;

namespace WebCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AddLoanServiceHandler _addLoanServiceHandler;
        private readonly IBaseServiceHander<IRequest> _baseServiceHander;
        private readonly ILoanServices _loanService;

        public HomeController(ILogger<HomeController> logger
            , ILoanServices loanService
            , AddLoanServiceHandler addLoanServiceHandler
            , IBaseServiceHander<IRequest> baseServiceHander
            )
        {
            _logger = logger;
            _loanService = loanService;
            _addLoanServiceHandler = addLoanServiceHandler;
            _baseServiceHander = baseServiceHander;
        }

        public IActionResult Index()
        {
            var loanApplicationDemo = new LoanApplicationModel()
            {
                Amount = 10000,
                CustomerId = 1,
                LoanStatus = 1
            };

            _addLoanServiceHandler.Execute(loanApplicationDemo);
            //CustomerModel customer = new CustomerModel();
            //GetLoanApplicationsForCustomer(customer);
            return View();
        }

        public JsonResult GetLoanApplicationsForCustomer(CustomerModel customer)
        {
            customer.CustomerId = 1;
            var loanApplications = new List<LoanApplication>();

            if (customer.CustomerId.HasValue)
            {
                loanApplications = _loanService.GetActiveLoanApplication(customer.CustomerId.Value);
            }

            return Json(loanApplications);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
