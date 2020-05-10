using MVC.Labs.Day2.EmployeeForm.Model;
using MVC.Labs.Day2.EmployeeForm.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVC.Labs.Day2.EmployeeForm.Managers
{
    public class EmployeeManager
    {

        ModelContext ctx = new ModelContext();
        public virtual IQueryable<Employee> GetAll()
         {
            return ctx.Employees;
        }
        public virtual Employee GetById(int Id)
        {
            Employee emp = ctx.Employees.Find(Id);
            return emp!=null ? emp : null;

        }

        public virtual Employee Add(Employee emp)
        {
            ctx.Employees.Add(emp);
            return ctx.SaveChanges() > 0 ? emp : null;
        }
        public virtual Employee Delete(Employee  emp)
        {
            //ctx.Entry(emp).State = EntityState.Deleted;

            ctx.Employees.Remove(emp);
            return ctx.SaveChanges() > 0 ? emp : null;
        }

        public virtual Employee Update(Employee emp)
        {
            ctx.Employees.Attach(emp);
            ctx.Entry(emp).State = EntityState.Modified;
            return ctx.SaveChanges() > 0 ? emp : null;

        }
    }
}