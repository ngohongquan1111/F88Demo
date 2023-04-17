using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVCDemo.Service.DataBaseContext;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebCore.Models;

namespace WebCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly MvcDemoDbContext _mvcDemoDbContext;
        public HomeController(ILogger<HomeController> logger, MvcDemoDbContext mvcDemoDbContext)
        {
            _logger = logger;
            _mvcDemoDbContext = mvcDemoDbContext;
        }

        public IActionResult Index()
        {
            var contact = _mvcDemoDbContext.Customer.ToList();
            return View();
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
