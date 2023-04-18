using MVCDemo.BaseServiceHandler.Domain.Model;
using WebCore.Models;

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