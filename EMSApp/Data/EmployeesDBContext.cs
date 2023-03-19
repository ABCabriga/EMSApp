using EMSApp.Models;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace EMSApp.Data
{
    public class EmployeesDBContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=EMSDB;Integrated Security=True;";
            optionsBuilder.UseSqlServer(connectionString)
                .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);

            base.OnConfiguring(optionsBuilder);
        }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder
        //}
        public DbSet<Employee> Employees { get; set; } // plural many
        public DbSet<Department> Departments { get; set; }
    }
}
