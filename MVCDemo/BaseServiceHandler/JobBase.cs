using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCDemo.BaseServiceHandler
{
    public interface IJobBase<TContext, out TResponse>
    {
        TResponse Execute(TContext context);
    }

    public abstract class JobBase<TContext,TResponse> : IJobBase<TContext,TResponse>
    {
        public TResponse Execute(TContext context)
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

        protected abstract TResponse Process(TContext context);
    }
}