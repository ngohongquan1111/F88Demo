using MVCDemo.DataBaseContext.Entity;
using MVCDemo.Service.DataBaseContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebCore.Models;

namespace WebCore.Repository
{

    public interface ILoanApplicationRepository
    {
        IEnumerable<LoanApplication> GetLoanApplicationByCustomerId(int customerId);
     
        bool UpdateLoanApplication(LoanApplicationModel loanApplication);
    }

    public class LoanApplicationRepository : ILoanApplicationRepository
    {
        private readonly MvcDemoDbContext _mvcDemoDbContext;

        public LoanApplicationRepository(MvcDemoDbContext mvcDemoDbContext)
        {
            _mvcDemoDbContext = mvcDemoDbContext;
        }

        public IEnumerable<LoanApplication> GetLoanApplicationByCustomerId(int customerId)
        {
            return _mvcDemoDbContext.LoanApplication.Where(x => x.CustomerId == customerId);
        }

        public bool UpdateLoanApplication(LoanApplicationModel loanApplication)
        {
            var application = _mvcDemoDbContext.LoanApplication.Find(loanApplication.ApplicationIndex);
            application.Amount = loanApplication.Amount;
            application.CustomerId = loanApplication.CustomerId;
            application.LoanStatus = loanApplication.LoanStatus;
            return _mvcDemoDbContext.SaveChanges() > 0;
        }
    }
}
