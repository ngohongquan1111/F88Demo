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
        private readonly IRequestFactoryContext _requestFactoryContext;

        public WorkFlow(IRequestFactoryContext requestFactoryContext)
        {
            _requestFactoryContext = requestFactoryContext;
        }

        public IResponse ExecuteRequest(IRequest request)
        {
            var request = _requestFactoryContext.CreatRequest(request);
        }
    }
}