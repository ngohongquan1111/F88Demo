using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCDemo.Service.Domain
{
    [Table("customer")]
    public class Customer
    {
        public int CustomerId { get; set; }


        public string CustomerName { get; set; }
    }
}