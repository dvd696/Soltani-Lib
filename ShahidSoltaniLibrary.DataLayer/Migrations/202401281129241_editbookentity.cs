namespace ShahidSoltaniLibrary.DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class editbookentity : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.UserBooks", "BookId", "dbo.Books");
            DropPrimaryKey("dbo.Books");
            DropColumn("dbo.Books", "UserId");
            AddColumn("dbo.Books", "BookId", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Books", "BookId");
            AddForeignKey("dbo.UserBooks", "BookId", "dbo.Books", "BookId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            AddColumn("dbo.Books", "UserId", c => c.Int(nullable: false, identity: true));
            DropForeignKey("dbo.UserBooks", "BookId", "dbo.Books");
            DropPrimaryKey("dbo.Books");
            DropColumn("dbo.Books", "BookId");
            AddPrimaryKey("dbo.Books", "UserId");
            AddForeignKey("dbo.UserBooks", "BookId", "dbo.Books", "UserId", cascadeDelete: true);
        }
    }
}
