using MVCDemo.DataBaseContext.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebCore.Models;
using WebCore.Repository;

namespace WebCore.Services.LoanService
{
    public interface ILoanServices
    {
        List<LoanApplication> GetActiveLoanApplication(int customerId);
    }

    public class LoanServices : ILoanServices
    {
        private readonly ILoanApplicationRepository _loanApplicationRepository;

        public LoanServices(ILoanApplicationRepository loanApplicationRepository)
        {
            _loanApplicationRepository = loanApplicationRepository;
        }

        public List<LoanApplication> GetActiveLoanApplication(int customerId)
        {
            var loanApplication = _loanApplicationRepository.GetLoanApplicationByCustomerId(customerId);

            return loanApplication.Any() ? loanApplication.Where(x => x.LoanStatus == 1).ToList() : new List<LoanApplication>();
        }
    }
}
