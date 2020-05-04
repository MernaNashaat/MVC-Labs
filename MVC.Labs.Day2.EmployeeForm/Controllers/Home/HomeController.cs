using MVC.Labs.Day2.EmployeeForm.Managers;
using MVC.Labs.Day2.EmployeeForm.Model;
using MVC.Labs.Day2.EmployeeForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Labs.Day2.EmployeeForm.Controllers.Home
{
    public class HomeController : Controller
    {
                 
        EmployeeManager em= new EmployeeManager();
        public ViewResult EmployeeForm()
        {
            return View();
        }
        [HttpPost]
        public ViewResult EmployeeForm(Employee employee)
        {
            if(ModelState.IsValid)
            {
               
             var result=em.Add(employee);
            return View("ThanksForm",employee);

            }
            return View();
        }
        public ViewResult ThanksForm()
        {
            return View(new Employee());
        }
    }
}