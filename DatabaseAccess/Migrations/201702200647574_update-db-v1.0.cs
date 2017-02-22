namespace DatabaseAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedbv10 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Member", "StudentCode", c => c.String());
            AddColumn("dbo.Member", "PhoneNumber", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Member", "PhoneNumber");
            DropColumn("dbo.Member", "StudentCode");
        }
    }
}
