using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DAL
{
    public class Context : DbContext
    {
        public Context()
            : base("name=Context")
        {

        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Employee>().MapToStoredProcedures();
            modelBuilder.Entity<Employee>().MapToStoredProcedures
                (p => p.Insert(a => a.HasName("spInsertEmployee")
                        .Parameter(n=>n.Name,"empName")
                        .Parameter(n=>n.Salary,"empSalary")
                        .Parameter(n=>n.DepartId,"empdeptId"))
                     .Update(a => a.HasName("spUpdateEmployee"))
                     .Delete(a => a.HasName("spDeleteEmployee")));
            modelBuilder.Entity<Department>().MapToStoredProcedures();
            base.OnModelCreating(modelBuilder);
        }
    }
}
