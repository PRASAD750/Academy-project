﻿namespace DAlayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fi : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        First_name = c.String(nullable: false),
                        Last_name = c.String(nullable: false),
                        DOB = c.DateTime(nullable: false),
                        Gender = c.Int(nullable: false),
                        Contact = c.Long(nullable: false),
                        Email = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        User_category = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Employees");
        }
    }
}
