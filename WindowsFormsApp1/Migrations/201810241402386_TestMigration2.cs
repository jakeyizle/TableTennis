namespace WindowsFormsApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TestMigration2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.People", "Mean", c => c.Double(nullable: false));
            AddColumn("dbo.People", "StandardDeviation", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.People", "StandardDeviation");
            DropColumn("dbo.People", "Mean");
        }
    }
}
