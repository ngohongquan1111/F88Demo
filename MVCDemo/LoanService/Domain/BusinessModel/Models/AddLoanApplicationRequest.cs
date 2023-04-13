using MVCDemo.Service.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCDemo.Service.Domain.BusinessModel.Models
{
    public class AddLoanApplicationRequest : IAddLoanApplicationRequest
    {
        public LoanApplication LoanApplication { get; set; }
    }
}