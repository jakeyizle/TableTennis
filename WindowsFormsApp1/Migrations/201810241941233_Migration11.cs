namespace WindowsFormsApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration11 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MatchPersons", "MatchResult", c => c.Int(nullable: false));
            DropColumn("dbo.MatchPersons", "Result");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MatchPersons", "Result", c => c.Int(nullable: false));
            DropColumn("dbo.MatchPersons", "MatchResult");
        }
    }
}
