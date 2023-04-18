using MVCDemo.BaseServiceHandler;
using MVCDemo.DataBaseContext.Entity;
using MVCDemo.Service.DataBaseContext;
using MVCDemo.Services.LoanServices.AddLoan.Domain.Context;
using MVCDemo.Services.LoanServices.AddLoan.Domain.Model;
using System;

namespace MVCDemo.Services.LoanService.AddLoan.Job
{
    public class AddLoanJob : IJobBase<IAddLoanJobContext, IAddLoanResponse>
    {
        private readonly MvcDemoDbContext _mvcDemoDbContext;
        public AddLoanJob(MvcDemoDbContext mvcDemoDbContext)
        {
            _mvcDemoDbContext = mvcDemoDbContext;
        }

        protected override IAddLoanResponse Process(IAddLoanJobContext context)
        {
            var newLoanApplication = new LoanApplication()
            {
                Amount = context.LoanApplication.Amount,
                CustomerId = context.LoanApplication.CustomerId,
                LoanStatus = context.LoanApplication.LoanStatus
            };

            var addedLoan = _mvcDemoDbContext.LoanApplication.Add(newLoanApplication);

            return new AddLoanResponse() { 
                AddedLoanApplication = new LoanApplication() { 
                    //ApplicationIndex = addedLoan.ApplicationINdex
                },
                IsSuccess = true
            };
        }
    }
}