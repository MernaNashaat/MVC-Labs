using MVC.Labs.Day2.EmployeeForm.Managers;
using MVC.Labs.Day2.EmployeeForm.Model;
using MVC.Labs.Day2.EmployeeForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Labs.Day2.EmployeeForm.Controllers
{
    public class EmployeeController : Controller
    {

        ModelContext ctx = new ModelContext();
        EmployeeManager em = new EmployeeManager();
        public ViewResult EmployeeForm()
        {
            return View();
        }
        [HttpPost]
        public ViewResult EmployeeForm(Employee employee)
        {
            if (ModelState.IsValid)
            {

                var result = em.Add(employee);
                return View("ThanksForm", employee);

            }
            return View();
        }
        public ViewResult ThanksForm()
        {
            return View(new Employee());
        }

        public ViewResult EmployeesList()
        {
            return View("EmployeesList", em.GetAll().ToList());
        }
        public ViewResult EmployeeDetails(int id)
        {
            Employee emp = em.GetById(id);
            return View("EmployeeDetails", emp);
        }
        public ViewResult DeleteEmployee(int id)
        {
            Employee emp = ctx.Employees.Find(id);
            em.Delete(emp);
            return View("EmployeesList", em.GetAll().ToList());

        }
        public ViewResult EditEmployee(int id)
        {
            Employee emp = ctx.Employees.Find(id);
            emp.Name = "merna";
            Employee newEmp=em.Update(emp);
            return View("EmployeeForm",newEmp );
        }


    }
}