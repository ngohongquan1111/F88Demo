using MVCDemo.DataBaseContext.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebCore.Models;
using WebCore.Repository;

namespace WebCore.Services.CustomerService
{
    public interface ICustomerService
    {
        Customer GetCustomerById(CustomerModel customer);
    }
    public class CustomerServices : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerServices(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public Customer GetCustomerById(CustomerModel customer)
        {
            return _customerRepository.GetCustomer(customer.CustomerId.Value);
        }
    }
}
