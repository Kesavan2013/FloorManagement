using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeGridApp.Models
{
    public class DB
    {
        public static List<Employee> Employees { get; set; }

        static DB()
        {
            Employees = new List<Employee>{
                new Employee() { Name="test",Company="Photon",Department="HR",Designation="Recruiter",Id=1,IsActive=true,Salary=7000,Year=2007 },
                new Employee() { Name="test1",Company="Photon1",Department="HR1",Designation="Recruiter",Id=1,IsActive=true,Salary=7000,Year=2007 },
                    new Employee() { Name="test2",Company="Photon2",Department="HR2",Designation="Recruiter",Id=1,IsActive=true,Salary=7000,Year=2007 }
            };
        }
    }
}