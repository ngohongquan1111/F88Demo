using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCDemo.Service.Workflow
{
    public interface IWorkFlow<TRequest>
    {
        void ExecuteRequest(TRequest request);
    }

    public class WorkFlow : IWorkFlow
    {
    }
}