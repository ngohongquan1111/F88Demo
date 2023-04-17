using MVCDemo.DataBaseContext.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCDemo.Service.DataBaseContext
{
    public interface IMvcDemoDbContext
    {
         DbSet<Customer> Customer { get; set; }

         DbSet<LoanApplication> LoanApplication { get; set; }
    }
}