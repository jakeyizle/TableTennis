namespace WindowsFormsApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration7 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.PersonMatches", "Person_PersonId", "dbo.People");
            DropForeignKey("dbo.PersonMatches", "Match_MatchId", "dbo.Matches");
            DropIndex("dbo.PersonMatches", new[] { "Person_PersonId" });
            DropIndex("dbo.PersonMatches", new[] { "Match_MatchId" });
            CreateTable(
                "dbo.MatchPersons",
                c => new
                    {
                        MatchId = c.Int(nullable: false),
                        PersonId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.MatchId, t.PersonId })
                .ForeignKey("dbo.Matches", t => t.MatchId, cascadeDelete: true)
                .ForeignKey("dbo.People", t => t.PersonId, cascadeDelete: true)
                .Index(t => t.MatchId)
                .Index(t => t.PersonId);
            
            DropTable("dbo.PersonMatches");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.PersonMatches",
                c => new
                    {
                        Person_PersonId = c.Int(nullable: false),
                        Match_MatchId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Person_PersonId, t.Match_MatchId });
            
            DropForeignKey("dbo.MatchPersons", "PersonId", "dbo.People");
            DropForeignKey("dbo.MatchPersons", "MatchId", "dbo.Matches");
            DropIndex("dbo.MatchPersons", new[] { "PersonId" });
            DropIndex("dbo.MatchPersons", new[] { "MatchId" });
            DropTable("dbo.MatchPersons");
            CreateIndex("dbo.PersonMatches", "Match_MatchId");
            CreateIndex("dbo.PersonMatches", "Person_PersonId");
            AddForeignKey("dbo.PersonMatches", "Match_MatchId", "dbo.Matches", "MatchId", cascadeDelete: true);
            AddForeignKey("dbo.PersonMatches", "Person_PersonId", "dbo.People", "PersonId", cascadeDelete: true);
        }
    }
}
