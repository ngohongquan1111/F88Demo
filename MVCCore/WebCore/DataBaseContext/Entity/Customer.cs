using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCDemo.DataBaseContext.Entity
{
    [Table ("Customer")]
    public class Customer
    {
        public string CustomerName { get; set; }

        public string PhoneNumber { get; set; }

        [Key]
        public int CustomerId { get; set; }
    }
}