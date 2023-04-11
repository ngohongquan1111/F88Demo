using MVCDemo.Service.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCDemo.Service.Workflow
{
    public interface IWorkFlow<in TRequest, out TResponse>
    {
        TResponse ExecuteRequest(TRequest request);
    }

    public class WorkFlow : IWorkFlow<IRequest, IResponse>
    {
        public IResponse ExecuteRequest(IRequest request)
        {
            throw new NotImplementedException();
        }
    }
}