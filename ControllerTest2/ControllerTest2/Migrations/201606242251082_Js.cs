namespace ControllerTest2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Js : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.TblEmployee", "Salary", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.TblEmployee", "Salary", c => c.Int(nullable: false));
        }
    }
}
