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
            ViewBag.Action = "Add";
            return View();
        }
        [HttpPost]
        public ActionResult EmployeeForm(Employee employee)
        {
            if (ModelState.IsValid)
            {

                var result = em.Add(employee);
                TempData["message"] = "Employee added successfully";
                return RedirectToAction(nameof(EmployeesList));


            }
            ViewBag.Action = "Add";
            return View("EmployeeForm");
        }
        public ViewResult ThanksForm()
        {
            return View(new Employee());
        }

        public ViewResult EmployeesList()
        {
            return View("EmployeesList", em.GetAll().ToList());
        }
        public ActionResult EmployeeDetails(int id)
        {
            Employee emp = em.GetById(id);
            if(emp!=null)
            {
            return View("EmployeeDetails", emp);

            }
            return HttpNotFound("User Not Found");
        }
        [HttpPost]
        public ActionResult DeleteEmployee(int id)
        {
            Employee emp = ctx.Employees.Find(id);
            if(emp!=null)
            {
                ctx.Employees.Remove(emp);
                ctx.SaveChanges();

                //em.Delete(emp );
                //return View("EmployeesList", em.GetAll().ToList());
                return Json(true);

                //return RedirectToAction(nameof(EmployeesList));

            }
            return HttpNotFound("Employee not found");
            

        }
        public ActionResult EditEmployee(int id)
        {
            Employee emp = ctx.Employees.Find(id);
            if(emp!=null)
            {
                ViewBag.Action = "Edit";
                return View("EmployeeForm", emp);
            }
            return HttpNotFound("Employee not found");
        }
        [HttpPost]
        public ActionResult EditEmployee(Employee emp)
        {
            if(ModelState.IsValid)
            {
                em.Update(emp);
                TempData["message"] = "Employee Edited successfully";
                return RedirectToAction(nameof(EmployeesList));
                //return View("EmployeesList", em.GetAll().ToList());

            }
            ViewBag.Action = "Edit";
            return View("EmployeeForm",emp);
        }



    }
}