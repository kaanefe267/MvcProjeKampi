﻿namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _mig_writertitle_edit : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Writers", "WriterTitle", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Writers", "WriterTitle");
        }
    }
}
