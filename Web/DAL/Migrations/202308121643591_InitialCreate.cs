namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Users", "UserPassword", c => c.String(nullable: false, maxLength: 6));
            DropColumn("dbo.Users", "Type");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "Type", c => c.String());
            AlterColumn("dbo.Users", "UserPassword", c => c.String(nullable: false, maxLength: 20));
        }
    }
}
