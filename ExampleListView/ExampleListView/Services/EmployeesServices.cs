using ExampleListView.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleListView.Services
{
   public class EmployeesServices //for getting and creating employees
    {
        public List<Employee> GetEmployees()
        {
            var list = new List<Employee>
            {
                new Employee
                {
                    Name="Mohamed",
                    Departement="Backend" },
                  new Employee{
                    Name="Refka",
                    Departement="FrontEnd" },
                   new Employee{
                    Name="Aiman",
                    Departement="Services" },
            };
            return list;
        }
    }
}
