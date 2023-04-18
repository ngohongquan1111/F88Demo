using BaseServiceHandler.Interfaces;
using WebCore.Models;

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