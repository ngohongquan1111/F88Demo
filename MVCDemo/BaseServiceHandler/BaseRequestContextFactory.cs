using MVCDemo.BaseServiceHandler.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCDemo.BaseServiceHandler.Domain
{
    public interface IBasseRequestContextFactory<in TRequest, out TJobContext>
    {
       IJobContext Create(TRequest request);
    }

    public abstract class BaseRequestContextFactory<TRequest, TJobContext> : IBasseRequestContextFactory<TRequest, TJobContext>
    {
        public abstract IJobContext Create(TRequest request);
    }
}