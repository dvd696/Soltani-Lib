namespace ShahidSoltaniLibrary.DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class editbook : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Books", "RemainNumber", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Books", "RemainNumber");
        }
    }
}
