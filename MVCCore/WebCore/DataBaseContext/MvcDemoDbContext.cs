using Microsoft.EntityFrameworkCore;
using MVCDemo.DataBaseContext.Entity;
using MySql.Data.MySqlClient;

namespace MVCDemo.Service.DataBaseContext
{
    public class MvcDemoDbContext : DbContext
    {
        public MvcDemoDbContext(DbContextOptions<MvcDemoDbContext> options)
            : base(options)
        {
        }

        public DbSet<Customer> Customer { get; set; }

        public DbSet<LoanApplication> LoanApplication { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        }
    }
}