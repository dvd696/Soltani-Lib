namespace ShahidSoltaniLibrary.DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class loan : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.UserBooks", "UserId", "dbo.Users");
            DropIndex("dbo.UserBooks", new[] { "UserId" });
            CreateTable(
                "dbo.Loans",
                c => new
                    {
                        LoanId = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        Finish = c.Boolean(nullable: false),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.LoanId)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            AddColumn("dbo.UserBooks", "LoanId", c => c.Int(nullable: false));
            CreateIndex("dbo.UserBooks", "LoanId");
            AddForeignKey("dbo.UserBooks", "LoanId", "dbo.Loans", "LoanId", cascadeDelete: true);
            DropColumn("dbo.UserBooks", "UserId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.UserBooks", "UserId", c => c.Int(nullable: false));
            DropForeignKey("dbo.UserBooks", "LoanId", "dbo.Loans");
            DropForeignKey("dbo.Loans", "UserId", "dbo.Users");
            DropIndex("dbo.Loans", new[] { "UserId" });
            DropIndex("dbo.UserBooks", new[] { "LoanId" });
            DropColumn("dbo.UserBooks", "LoanId");
            DropTable("dbo.Loans");
            CreateIndex("dbo.UserBooks", "UserId");
            AddForeignKey("dbo.UserBooks", "UserId", "dbo.Users", "UserId", cascadeDelete: true);
        }
    }
}
