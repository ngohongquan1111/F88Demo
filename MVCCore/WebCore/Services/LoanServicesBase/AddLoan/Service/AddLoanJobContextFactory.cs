using MVCDemo.BaseServiceHandler;
using MVCDemo.Services.LoanService.AddLoan.Domain.Context;
using MVCDemo.Services.LoanServices.AddLoan.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCDemo.Services.LoanServices.AddLoan.Service
{
    public class AddLoanJobContextFactory : IJobContextFactory<IAddLoanRequest, IAddLoanJobContext>
    {
        public IAddLoanJobContext Create(IAddLoanRequest request)
        {
            return new AddLoanJobContext()
            {
                LoanApplication = request.LoanApplication
            };
        }
    }
}
