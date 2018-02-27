using ExampleListView.Models;
using ExampleListView.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ExampleListView.ViewModels
{
   public class MainViewModel : INotifyPropertyChanged
    {
        //use employee entity
        public List<Employee> _employeesList;
        public List<Employee> EmployeesList   
        {
            get { return _employeesList; }
            set
            {
                _employeesList = value;
              OnPropertyChanged();
            }
        }
        public MainViewModel()
        {
            var employeesServices = new EmployeesServices();
            EmployeesList = employeesServices.GetEmployees();
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyname=null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }
    }
}
