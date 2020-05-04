using MVC.Labs.Day2.EmployeeForm.Model;
using MVC.Labs.Day2.EmployeeForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC.Labs.Day2.EmployeeForm.Managers
{
    public class EmployeeManager
    {
        ModelContext ctx = new ModelContext();
        public virtual Employee Add(Employee entity)
        {
            ctx.Employees.Add(entity);
            return ctx.SaveChanges() > 0 ? entity : null;
        }
    }
}