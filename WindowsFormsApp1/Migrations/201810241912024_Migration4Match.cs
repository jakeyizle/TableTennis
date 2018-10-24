namespace WindowsFormsApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration4Match : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.People", "GamesPlayed");
            DropColumn("dbo.People", "WinPercentage");
        }
        
        public override void Down()
        {
            AddColumn("dbo.People", "WinPercentage", c => c.Double(nullable: false));
            AddColumn("dbo.People", "GamesPlayed", c => c.Int(nullable: false));
        }
    }
}
