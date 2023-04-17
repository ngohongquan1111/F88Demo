using BaseServiceHandler.Interfaces;
using MVCDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCDemo.Services.LoanService.AddLoan.Domain.Context
{
    public interface IAddLoanRequest : IRequest
    {
        LoanApplicationModel LoanApplication { get; set; }
    }

    public class AddLoanRequest : IAddLoanRequest
    {
        public LoanApplicationModel LoanApplication { get; set; }
    }
}