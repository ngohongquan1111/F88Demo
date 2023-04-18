using BaseServiceHandler.Interfaces;
using MVCDemo.BaseServiceHandler.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCDemo.BaseServiceHandler.Domain
{
    public interface IBaseRequestContextFactory<in TRequest, out TJob>
    {
        TJob Create(TRequest request);
    }
}