namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class intiDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tickets",
                c => new
                    {
                        TicketId = c.String(nullable: false, maxLength: 128),
                        SeatNumber = c.String(),
                        TicketPrice = c.Int(nullable: false),
                        Date = c.String(),
                        ShowTime = c.String(),
                        TotalSeats = c.Int(nullable: false),
                        AvailableSeats = c.Int(nullable: false),
                        UserId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.TicketId)
                .ForeignKey("dbo.Users", t => t.UserId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        UserName = c.String(nullable: false),
                        UserEmail = c.String(nullable: false),
                        UserPhone = c.Int(nullable: false),
                        UserGender = c.String(nullable: false),
                        UserPassword = c.String(nullable: false, maxLength: 20),
                        Type = c.String(),
                    })
                .PrimaryKey(t => t.UserId);
            
            CreateTable(
                "dbo.UserTokens",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TKey = c.String(nullable: false, maxLength: 100),
                        CreatedTime = c.DateTime(nullable: false),
                        ExpiredTime = c.DateTime(),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserTokens", "UserId", "dbo.Users");
            DropForeignKey("dbo.Tickets", "UserId", "dbo.Users");
            DropIndex("dbo.UserTokens", new[] { "UserId" });
            DropIndex("dbo.Tickets", new[] { "UserId" });
            DropTable("dbo.UserTokens");
            DropTable("dbo.Users");
            DropTable("dbo.Tickets");
        }
    }
}
