namespace MVC.Labs.Day2.EmployeeForm.Model
{
    using MVC.Labs.Day2.EmployeeForm.Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ModelContext : DbContext
    {
     
        public ModelContext()
            : base("name=ModelContext")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ModelContext,
         MVC.Labs.Day2.EmployeeForm.Migrations.Configuration>("ModelContext"));
        }

        

         public virtual DbSet<Employee> Employees { get; set; }
    }

}