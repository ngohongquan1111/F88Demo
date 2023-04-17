using BaseServiceHandler.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCDemo.Models
{
    public class LoanApplicationModel : IRequest
    {
        public int Amount { get; set; }

        public int CustomerId { get; set; }

        public int LoanStatus { get; set; }
    }
}