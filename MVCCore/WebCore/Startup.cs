using BaseServiceHandler.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MVCDemo.BaseServiceHandler;
using MVCDemo.BaseServiceHandler.Domain;
using MVCDemo.Service.DataBaseContext;
using MVCDemo.Services.LoanService.AddLoan.Domain.Context;
using MVCDemo.Services.LoanService.AddLoan.Job;
using MVCDemo.Services.LoanServices.AddLoan;
using MVCDemo.Services.LoanServices.AddLoan.Domain.Context;
using MVCDemo.Services.LoanServices.AddLoan.Domain.Model;
using MVCDemo.Services.LoanServices.AddLoan.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebCore.Repository;
using WebCore.Services.LoanService;

namespace WebCore
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            var connectionString = Configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<MvcDemoDbContext>(options =>
               options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

            RegisterBaseService(services);
            RegisterLoanService(services);

            ThreeLayersServiceRegistration(services);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }

        private void RegisterBaseService(IServiceCollection services)
        {
            services.AddScoped<IBaseServiceHander<IRequest>, ServiceHandler>();
            services.AddScoped(typeof(IJobBase<,>), typeof(JobBase<,>));
            //services.AddScoped(typeof(IJobBase<,>), typeof(JobBase<,>));
        }

        private void RegisterLoanService(IServiceCollection services)
        {
            services.AddScoped<AddLoanServiceHandler>();
            services.AddScoped<IJobBase<IAddLoanJobContext, IAddLoanResponse>, AddLoanJob>();
            services.AddScoped<IBaseRequestContextFactory<IAddLoanRequest, IJobBase<IAddLoanJobContext, IAddLoanResponse>>, LoanRequestContextFactory>();
            services.AddScoped<IJobContextFactory<IAddLoanRequest, IAddLoanJobContext>, AddLoanJobContextFactory>();
        }

        private void ThreeLayersServiceRegistration(IServiceCollection services)
        {
            services.AddScoped<ILoanServices, LoanServices>();
            services.AddScoped<ILoanApplicationRepository, LoanApplicationRepository>();
        }
    }
}
