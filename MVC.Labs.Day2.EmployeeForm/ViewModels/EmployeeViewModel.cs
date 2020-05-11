using MVC.Labs.Day2.EmployeeForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC.Labs.Day2.EmployeeForm.ViewModels
{
    public class EmployeeViewModel
    {
        public List<Employee> employees { get; set; }
        public Employee employee { get; set; }
    
    }
}