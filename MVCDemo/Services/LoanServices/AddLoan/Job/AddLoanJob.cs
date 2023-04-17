using MVCDemo.BaseServiceHandler;
using MVCDemo.DataBaseContext.Entity;
using MVCDemo.Service.DataBaseContext;
using MVCDemo.Services.LoanServices.AddLoan.Domain.Context;
using MVCDemo.Services.LoanServices.AddLoan.Domain.Model;
using System;

namespace MVCDemo.Services.LoanService.AddLoan.Job
{
    public class AddLoanJob : JobBase<IAddLoanJobContext, IAddLoanResponse>
    {
        private readonly IServiceProvider _serviceProvider;

        public AddLoanJob(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        protected override IAddLoanResponse Process(IAddLoanJobContext context)
        {
            var dbContext = (IMvcDemoDbContext)_serviceProvider.GetService(typeof(IMvcDemoDbContext));

            var newLoanApplication = new LoanApplication()
            {
                Amount = context.LoanApplication.Amount,
                CustomerId = context.LoanApplication.CustomerId,
                LoanStatus = context.LoanApplication.LoanStatus
            };

            var addedLoan =  dbContext.LoanApplication.Add(newLoanApplication);

            return new AddLoanResponse() { 
                AddedLoanApplication = addedLoan,
                IsSuccess = true
            };
        }
    }
}