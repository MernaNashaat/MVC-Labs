namespace MVC.Labs.Day2.EmployeeForm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EmpDeptRelation : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "FK_DeptId", c => c.Int());
            CreateIndex("dbo.Employees", "FK_DeptId");
            AddForeignKey("dbo.Employees", "FK_DeptId", "dbo.Departments", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "FK_DeptId", "dbo.Departments");
            DropIndex("dbo.Employees", new[] { "FK_DeptId" });
            DropColumn("dbo.Employees", "FK_DeptId");
        }
    }
}
