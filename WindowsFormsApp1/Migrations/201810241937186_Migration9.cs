namespace WindowsFormsApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration9 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Matches", "WinningScore", c => c.Int(nullable: false));
            AddColumn("dbo.Matches", "LosingScore", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Matches", "LosingScore");
            DropColumn("dbo.Matches", "WinningScore");
        }
    }
}
