using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class EmpAndDeptOperations
    {
        #region Employee
        public List<Employee> GetEmp()
        {
            using (var context = new Context())
            {
                List<Employee> employees = context.Employees.ToList();
                return employees;
            }
        }
        public void AddEmp(Employee emp)
        {
            using (var context = new Context())
            {
                context.Employees.Add(emp);
                context.SaveChanges();
            }
        
        }
        public void UpdateEmp(Employee emp)
        {
            using (var context = new Context())
            {
                var employee = context.Employees.FirstOrDefault(x => x.Id == emp.Id);
                if (employee != null)
                {
                    employee.Name = emp.Name;
                    employee.Salary = emp.Salary;
                    employee.DepartId = emp.DepartId;
                    context.SaveChanges();
                }
            }
        
        }
        public void DeleteEmp(int id)
        {
            using (var context = new Context())
            {
                var employee = context.Employees.FirstOrDefault(x => x.Id == id);
                context.Employees.Remove(employee);
                context.SaveChanges();
            }

        }
        #endregion
        #region Department
        public List<Department> GetDept()
        {
            using (var context = new Context())
            {
                List<Department> departments = context.Departments.ToList();
                return departments;
            }
        }
        public void AddDept(Department dept)
        {
            using (var context = new Context())
            {
                context.Departments.Add(dept);
                context.SaveChanges();
            }
        }
        public void UpdateDept()
        {
            using (var context = new Context())
            {

            }
        }
        public void DeleteDept()
        {
            using (var context = new Context())
            {

            }
        }
        #endregion
    }
}
