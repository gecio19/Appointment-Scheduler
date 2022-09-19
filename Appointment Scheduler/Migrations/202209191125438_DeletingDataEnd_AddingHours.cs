namespace Appointment_Scheduler.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeletingDataEnd_AddingHours : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Mettings", "Start_Hours", c => c.DateTime(nullable: false));
            AddColumn("dbo.Mettings", "End_Hours", c => c.DateTime(nullable: false));
            DropColumn("dbo.Mettings", "DateTime_End");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Mettings", "DateTime_End", c => c.DateTime(nullable: false));
            DropColumn("dbo.Mettings", "End_Hours");
            DropColumn("dbo.Mettings", "Start_Hours");
        }
    }
}
