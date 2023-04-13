using MVCDemo.Service.Domain;
using MVCDemo.Service.Domain.BusinessModel.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCDemo.Service
{
    public interface IRequestFactoryContext<in TRequest, out TCandidate>
    {
        TCandidate CreateJob(TRequest request);
    }

    public class RequestFactory : IRequestFactoryContext<IRequest, IScheduleJobContext>
    {
        public IScheduleJob CreateJob(IRequest request)
        {
            throw new NotImplementedException();
        }
    }
}