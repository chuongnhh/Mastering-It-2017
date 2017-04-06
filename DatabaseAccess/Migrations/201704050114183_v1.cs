namespace DatabaseAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Answer",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        AnswerLabel = c.String(),
                        AnswerName = c.String(),
                        IsTrue = c.Boolean(nullable: false),
                        QuestionId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Question", t => t.QuestionId)
                .Index(t => t.QuestionId);
            
            CreateTable(
                "dbo.Question",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        QuestionLabel = c.String(),
                        QuestionName = c.String(),
                        GameId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Game", t => t.GameId)
                .Index(t => t.GameId);
            
            CreateTable(
                "dbo.Game",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        GameName = c.String(),
                        GameTime = c.Int(nullable: false),
                        LevelId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Level", t => t.LevelId)
                .Index(t => t.LevelId);
            
            CreateTable(
                "dbo.Level",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        LevelName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Team",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        TeamName = c.String(),
                        LevelId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Level", t => t.LevelId)
                .Index(t => t.LevelId);
            
            CreateTable(
                "dbo.Member",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        MemberName = c.String(),
                        StudentCode = c.String(),
                        PhoneNumber = c.String(),
                        TeamId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Team", t => t.TeamId)
                .Index(t => t.TeamId);
            
            CreateTable(
                "dbo.Score",
                c => new
                    {
                        TeamId = c.Guid(nullable: false),
                        GameId = c.Guid(nullable: false),
                        LevelId = c.Guid(nullable: false),
                        ScoreNumber = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.TeamId, t.GameId, t.LevelId })
                .ForeignKey("dbo.Game", t => t.GameId)
                .ForeignKey("dbo.Level", t => t.LevelId)
                .ForeignKey("dbo.Team", t => t.TeamId)
                .Index(t => t.TeamId)
                .Index(t => t.GameId)
                .Index(t => t.LevelId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Score", "TeamId", "dbo.Team");
            DropForeignKey("dbo.Score", "LevelId", "dbo.Level");
            DropForeignKey("dbo.Score", "GameId", "dbo.Game");
            DropForeignKey("dbo.Answer", "QuestionId", "dbo.Question");
            DropForeignKey("dbo.Question", "GameId", "dbo.Game");
            DropForeignKey("dbo.Game", "LevelId", "dbo.Level");
            DropForeignKey("dbo.Member", "TeamId", "dbo.Team");
            DropForeignKey("dbo.Team", "LevelId", "dbo.Level");
            DropIndex("dbo.Score", new[] { "LevelId" });
            DropIndex("dbo.Score", new[] { "GameId" });
            DropIndex("dbo.Score", new[] { "TeamId" });
            DropIndex("dbo.Member", new[] { "TeamId" });
            DropIndex("dbo.Team", new[] { "LevelId" });
            DropIndex("dbo.Game", new[] { "LevelId" });
            DropIndex("dbo.Question", new[] { "GameId" });
            DropIndex("dbo.Answer", new[] { "QuestionId" });
            DropTable("dbo.Score");
            DropTable("dbo.Member");
            DropTable("dbo.Team");
            DropTable("dbo.Level");
            DropTable("dbo.Game");
            DropTable("dbo.Question");
            DropTable("dbo.Answer");
        }
    }
}
