using BaseServiceHandler.Interfaces;
using MVCDemo.DataBaseContext.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCDemo.Services.LoanServices.AddLoan.Domain.Context
{
    public interface IAddLoanResponse : IResponse
    {
        bool IsSuccess { get; set; }

        LoanApplication AddedLoanApplication { get; set; }
    }

    public class AddLoanResponse : IAddLoanResponse
    {
        public bool IsSuccess { get; set; }

        public LoanApplication AddedLoanApplication { get; set; }
    }
}