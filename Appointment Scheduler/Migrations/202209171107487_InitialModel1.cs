namespace Appointment_Scheduler.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Scheduls",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Customer_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.Customer_Id)
                .Index(t => t.Customer_Id);
            
            CreateTable(
                "dbo.Mettings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DateTime_Start = c.DateTime(nullable: false),
                        DateTime_End = c.DateTime(nullable: false),
                        Schedul_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Scheduls", t => t.Schedul_Id)
                .Index(t => t.Schedul_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Scheduls", "Customer_Id", "dbo.Customers");
            DropForeignKey("dbo.Mettings", "Schedul_Id", "dbo.Scheduls");
            DropIndex("dbo.Mettings", new[] { "Schedul_Id" });
            DropIndex("dbo.Scheduls", new[] { "Customer_Id" });
            DropTable("dbo.Mettings");
            DropTable("dbo.Scheduls");
            DropTable("dbo.Customers");
        }
    }
}
