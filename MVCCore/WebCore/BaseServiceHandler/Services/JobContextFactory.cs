using BaseServiceHandler.Interfaces;
using MVCDemo.BaseServiceHandler.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCDemo.BaseServiceHandler
{
    public interface IJobContextFactory<TContext, TJobContext>
    {
        TJobContext Create(TContext request);
    }
}