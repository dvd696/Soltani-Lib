namespace ShahidSoltaniLibrary.DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addbooks : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        CategoryId = c.Int(nullable: false),
                        Title = c.String(nullable: false),
                        Number = c.Int(nullable: false),
                        CanLoan = c.Boolean(nullable: false),
                        Floor = c.String(nullable: false),
                        Shelf = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .Index(t => t.CategoryId);
            
            CreateTable(
                "dbo.UserBooks",
                c => new
                    {
                        UB_Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        BookId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UB_Id)
                .ForeignKey("dbo.Books", t => t.BookId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.BookId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserBooks", "UserId", "dbo.Users");
            DropForeignKey("dbo.UserBooks", "BookId", "dbo.Books");
            DropForeignKey("dbo.Books", "CategoryId", "dbo.Categories");
            DropIndex("dbo.UserBooks", new[] { "BookId" });
            DropIndex("dbo.UserBooks", new[] { "UserId" });
            DropIndex("dbo.Books", new[] { "CategoryId" });
            DropTable("dbo.UserBooks");
            DropTable("dbo.Books");
        }
    }
}
