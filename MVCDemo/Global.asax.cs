using BaseServiceHandler.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using MVCDemo.BaseServiceHandler;
using MVCDemo.Service.DataBaseContext;
using MVCDemo.Services.LoanService.AddLoan.Job;
using MVCDemo.Services.LoanServices.AddLoan;
using MVCDemo.Services.LoanServices.AddLoan.Domain.Context;
using MVCDemo.Services.LoanServices.AddLoan.Domain.Model;
using System;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace MVCDemo
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            var serviceCollections = new ServiceCollection();
            RegisterDbContext(serviceCollections);
        }

        private void RegisterDbContext(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IMvcDemoDbContext, MvcDemoDbContext>();

            serviceCollection.AddScoped<IJobBase<IAddLoanJobContext, IAddLoanResponse>, AddLoanJob>();

            serviceCollection.AddScoped<IBaseServiceHander<IRequest>, ServiceHandler>();

            serviceCollection.AddScoped<ServiceHandler, AddLoanServiceHandler>();

            serviceCollection.AddScoped<ITestDI,TestDI>();

            DependencyResolver.SetResolver(new MyDependencyResolver(serviceCollection.BuildServiceProvider()));
        }


        public class MyDependencyResolver : IDependencyResolver
        {
            private readonly IServiceProvider _serviceProvider;

            public MyDependencyResolver(IServiceProvider serviceProvider)
            {
                _serviceProvider = serviceProvider;
            }

            public object GetService(Type serviceType)
            {
                return _serviceProvider.GetService(serviceType);
            }

            public IEnumerable<object> GetServices(Type serviceType)
            {
                return _serviceProvider.GetServices(serviceType);
            }
        }
    }
}
