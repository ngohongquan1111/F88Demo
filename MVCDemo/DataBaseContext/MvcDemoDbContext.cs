using MVCDemo.DataBaseContext;
using MVCDemo.DataBaseContext.Entity;
using MySql.Data.EntityFramework;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCDemo.Service.DataBaseContext
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class MvcDemoDbContext : DbContext, IMvcDemoDbContext
    {
        public MvcDemoDbContext() : base(ConfigurationManager.ConnectionStrings["MyDBContext"].ConnectionString)
        {

        }

        public DbSet<Customer> Customer { get; set; }

        public DbSet<LoanApplication> LoanApplication { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}