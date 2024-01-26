namespace ShahidSoltaniLibrary.DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addregistertobooks : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Books", "RegisterDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Books", "RegisterDate");
        }
    }
}
