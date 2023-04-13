using BaseServiceHandler.Interfaces;
using MVCDemo.Service.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCDemo.Service.Domain
{
    public interface IAddLoanApplicationRequest : IRequest
    {
        LoanApplication LoanApplication { get; set; }
    }

    public interface IApproveLoanApplicationRequest : IRequest
    {
    }

    public interface IDeleteLoanApplicationRequest : IRequest
    {
    }

    public interface IRejectLoanApplicationRequest : IRequest
    {
    }
}