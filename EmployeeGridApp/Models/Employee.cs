using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeGridApp.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
        public string Department { get; set; }
        public string Company { get; set; }
        public int Year { get; set; }
        public decimal Salary { get; set; }
        public bool IsActive { get; set; }
    }
}