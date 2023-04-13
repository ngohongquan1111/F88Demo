using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCDemo.Service.Domain.BusinessModel.Models
{
    public class RejectLoanApplicationRequest : IRequest
    {
        public int Index { get; set; }
    }
}