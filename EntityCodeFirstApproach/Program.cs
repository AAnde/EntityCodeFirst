using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace EntityCodeFirstApproach
{
    class Program
    {
        static void Main(string[] args)
        {
            GetEmployees();
            Console.ReadLine();
        }
        private static void GetEmployees()
        {
            using(var context = new Context())
            {
                var employees = context.Employees.ToList();
                Console.WriteLine(employees.Count.ToString());
            }
        }
    }
}
