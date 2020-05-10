namespace MVC.Labs.Day2.EmployeeForm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createDBtoLocal : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Employees", "FK_DeptId", c => c.Int());
            AlterColumn("dbo.Employees", "Name", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Employees", "Email", c => c.String(nullable: false, maxLength: 128));
            CreateIndex("dbo.Employees", "FK_DeptId");
            AddForeignKey("dbo.Employees", "FK_DeptId", "dbo.Departments", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "FK_DeptId", "dbo.Departments");
            DropIndex("dbo.Employees", new[] { "FK_DeptId" });
            AlterColumn("dbo.Employees", "Email", c => c.String());
            AlterColumn("dbo.Employees", "Name", c => c.String());
            DropColumn("dbo.Employees", "FK_DeptId");
            DropTable("dbo.Departments");
        }
    }
}
