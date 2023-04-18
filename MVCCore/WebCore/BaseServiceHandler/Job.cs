using BaseServiceHandler.Interfaces;
using MVCDemo.BaseServiceHandler.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCDemo.BaseServiceHandler
{
    public interface IJob<TContext, out TResponse>
    {
        TResponse Execute(TContext context);
    }

    public abstract class Job<TContext,TResponse> : IJob<IJobContext,IResponse>
    {
        public IResponse Execute(IJobContext context)
        {
            try
            {
              return Process(context);
            }
            catch (Exception exception)
            {
                throw;
            }
            
        }

        protected abstract IResponse Process(IJobContext context);
    }
}