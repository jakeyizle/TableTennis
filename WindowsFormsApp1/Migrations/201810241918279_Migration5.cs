namespace WindowsFormsApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration5 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Matches",
                c => new
                    {
                        MatchId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.MatchId);
            
            CreateTable(
                "dbo.PersonMatches",
                c => new
                    {
                        Person_PersonId = c.Int(nullable: false),
                        Match_MatchId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Person_PersonId, t.Match_MatchId })
                .ForeignKey("dbo.People", t => t.Person_PersonId, cascadeDelete: true)
                .ForeignKey("dbo.Matches", t => t.Match_MatchId, cascadeDelete: true)
                .Index(t => t.Person_PersonId)
                .Index(t => t.Match_MatchId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PersonMatches", "Match_MatchId", "dbo.Matches");
            DropForeignKey("dbo.PersonMatches", "Person_PersonId", "dbo.People");
            DropIndex("dbo.PersonMatches", new[] { "Match_MatchId" });
            DropIndex("dbo.PersonMatches", new[] { "Person_PersonId" });
            DropTable("dbo.PersonMatches");
            DropTable("dbo.Matches");
        }
    }
}
