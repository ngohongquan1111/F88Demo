using BaseServiceHandler.Interfaces;
using MVCDemo.BaseServiceHandler.Domain;
using MVCDemo.BaseServiceHandler.Domain.Model;
using System;

namespace MVCDemo.BaseServiceHandler
{
    public interface IBaseServiceHander<TRequest>
    {
        void Execute(TRequest request);
    }

    public class ServiceHandler : IBaseServiceHander<IRequest>
    {
        private readonly IServiceProvider _iContainer;

        public ServiceHandler(IServiceProvider serviceContainer)
        {
            _iContainer = serviceContainer;
        }

        public void Execute(IRequest request)
        {
            try
            {
                //var requestFactory = _windsorContainer.Resolve<IBaseRequestContextFactory<IRequest,IJobBase<IJobContext,IResponse>>>();
                //var jobContextFactory = _windsorContainer.Resolve<IJobContextFactory<IRequest, IJobContext>>();

                //var jobContext = jobContextFactory.Create(request);
                //var job = requestFactory.Create(request);
                var requestFactory = (IBaseRequestContextFactory < IRequest, IJobBase < IJobContext, IResponse >> )_iContainer.GetService(typeof(IBaseRequestContextFactory<IRequest,IJobBase<IJobContext,IResponse>>));
                var jobContextFactory = (IJobContextFactory<IRequest, IJobContext>)_iContainer.GetService(typeof(IJobContextFactory<IRequest, IJobContext>));


                var jobContext = jobContextFactory.Create(request);
                var job = requestFactory.Create(request);

                job.Execute(jobContext);

            }
            catch (Exception)
            {

                throw;
            }
           
        }
    }
}