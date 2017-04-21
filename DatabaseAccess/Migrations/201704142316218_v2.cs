namespace DatabaseAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Game", "TeamNumber", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Game", "TeamNumber");
        }
    }
}
