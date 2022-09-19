﻿namespace Appointment_Scheduler.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingNullableToDateTime : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Mettings", "DateTime_Start", c => c.DateTime());
            AlterColumn("dbo.Mettings", "Start_Hours", c => c.DateTime());
            AlterColumn("dbo.Mettings", "End_Hours", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Mettings", "End_Hours", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Mettings", "Start_Hours", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Mettings", "DateTime_Start", c => c.DateTime(nullable: false));
        }
    }
}
