using MVCDemo.BaseServiceHandler.Domain.Model;
using MVCDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCDemo.Services.LoanServices.AddLoan.Domain.Model
{
    public interface IAddLoanJobContext : IJobContext
    {
         LoanApplicationModel LoanApplication { get; set; }
    }

    public class AddLoanJobContext : IAddLoanJobContext
    {
        public LoanApplicationModel LoanApplication { get; set; }
    }
}