using MVCDemo.BaseServiceHandler;
using MVCDemo.BaseServiceHandler.Domain;
using MVCDemo.Services.LoanService.AddLoan.Domain.Context;
using MVCDemo.Services.LoanServices.AddLoan.Domain.Context;
using MVCDemo.Services.LoanServices.AddLoan.Domain.Model;
using System;

namespace MVCDemo.Services.LoanServices.AddLoan.Service
{
    public class LoanRequestContextFactory : IBaseRequestContextFactory<IAddLoanRequest, IJobBase<IAddLoanJobContext, IAddLoanResponse>>
    {
        //private readonly IWindsorContainer _windsorContainer;
        private readonly IServiceProvider _serviceProvider;

        public LoanRequestContextFactory(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        //public LoanRequestContextFactory(IWindsorContainer windsorContainer)
        //{
        //    _windsorContainer = windsorContainer;
        //}

        public IJobBase<IAddLoanJobContext, IAddLoanResponse> Create(IAddLoanRequest request)
        {
            //return _windsorContainer.ResolveAll<JobBase<IAddLoanJobContext, IAddLoanResponse>>().First() ?? null; 
            return (JobBase<IAddLoanJobContext, IAddLoanResponse>)_serviceProvider.GetService(typeof(JobBase<IAddLoanJobContext, IAddLoanResponse>)) ;
        }
    }
}