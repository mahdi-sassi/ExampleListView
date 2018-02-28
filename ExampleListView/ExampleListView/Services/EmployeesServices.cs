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
                    Departement="Backend",
                    image="user.svg",
                    PassWord="Backend",
                    UserName="Mohamed"
                },
                  new Employee{
                    Name="Refka",
                    Departement="FrontEnd",
                    image ="user.svg",
                    PassWord="FrontEnd",
                    UserName="Refka"
                  },
                   new Employee{
                    Name="Aiman",
                    Departement="Services",
                    image="user.svg",
                    PassWord="Services",
                    UserName="Aiman"
                   },
            };
            return list;
        }
    }
}
