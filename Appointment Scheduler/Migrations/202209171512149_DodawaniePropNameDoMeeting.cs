namespace Appointment_Scheduler.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DodawaniePropNameDoMeeting : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Mettings", "Name", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Mettings", "Name");
        }
    }
}
