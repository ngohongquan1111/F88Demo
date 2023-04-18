using BaseServiceHandler.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebCore.Models
{
    public class LoanApplicationModel : IRequest
    {
        public int ApplicationIndex { get; set; }

        public int Amount { get; set; }

        public int CustomerId { get; set; }

        public int LoanStatus { get; set; }
    }
}
