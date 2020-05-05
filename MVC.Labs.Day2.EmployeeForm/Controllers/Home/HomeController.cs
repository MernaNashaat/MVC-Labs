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
        public ActionResult Index()
        {
            return View();
        }


    }
}