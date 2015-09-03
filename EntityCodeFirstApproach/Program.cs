using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using DAL;

namespace EntityCodeFirstApproach
{
    class Program
    {
        static EmpAndDeptOperations operations;
        static Program()
        {
            UpdateDatabase();
            operations = new EmpAndDeptOperations();
        }
        #region Main
        static void Main(string[] args)
        {
            try
            {
                
                //DeleteEmployee();
                //AddDepartment();
                AddEmployee();
                //UpdateEmployee();
                GetEmployees();
                Console.WriteLine("success...");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
        #endregion
        #region databaseupdate
        private static void UpdateDatabase()
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<Context>());
        }
        #endregion
        #region EmployeeOperations
        private static void GetEmployees()
        {
            List<Employee> employees = operations.GetEmp();
            if (employees.Count > 0)
            {
                foreach (var emp in employees)
                    Console.WriteLine(emp.Name + " " + emp.Salary);
            }
        }
        private static void AddEmployee()
        {
            Employee emp = new Employee()
            {
                Name = "ashok",
                Salary = 25000
            };
            operations.AddEmp(emp);
        }
        private static void UpdateEmployee()
        {
            Employee emp = new Employee()
            {
                Id = 2,
                Name = "ashok",
                Salary = 25000,
                DepartId = 1
            };
            operations.UpdateEmp(emp);
        }
        private static void DeleteEmployee()
        {
            operations.DeleteEmp(1);
        }
        #endregion
        #region DepartmentOperation
        private static void AddDepartment()
        {
            Department dept = new Department()
            {
                Name = "IT"
            };
            operations.AddDept(dept);
        }
        #endregion

    }
}
