using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCDemo.Service
{
    public interface IRequestFactoryContext
    {
        void CreatRequest();
    }

    public class RequestFactory : IRequestFactoryContext
    {
        public void CreatRequest()
        {
            throw new NotImplementedException();
        }
    }
}