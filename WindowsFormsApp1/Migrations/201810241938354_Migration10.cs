namespace WindowsFormsApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration10 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Matches", "WinningScore", c => c.Int());
            AlterColumn("dbo.Matches", "LosingScore", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Matches", "LosingScore", c => c.Int(nullable: false));
            AlterColumn("dbo.Matches", "WinningScore", c => c.Int(nullable: false));
        }
    }
}
