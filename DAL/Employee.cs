using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Nullable<decimal> Salary { get; set; }
        public Nullable<int> DeptId { get; set; }
        [ForeignKey("DeptId")]
        public Department department { get; set; }

    }
}
