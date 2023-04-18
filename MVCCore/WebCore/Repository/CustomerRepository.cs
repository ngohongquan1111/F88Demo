using MVCDemo.DataBaseContext.Entity;
using MVCDemo.Service.DataBaseContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebCore.Models;

namespace WebCore.Repository
{

    public interface ICustomerRepository
    {
        Customer GetCustomer(int customerId);
    }

    public class CustomerRepository : ICustomerRepository
    {
        private readonly MvcDemoDbContext _mvcDemoDbContext;

        public CustomerRepository(MvcDemoDbContext mvcDemoDbContext)
        {
            _mvcDemoDbContext = mvcDemoDbContext;
        }

        public Customer GetCustomer(int customerId)
        {
            return _mvcDemoDbContext.Customer.Find(customerId);
               
        }
    }
}
