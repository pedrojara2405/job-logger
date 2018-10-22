namespace JobLogger.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Candidate",
                c => new
                    {
                        CandidateId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 10),
                        LastName = c.String(nullable: false, maxLength: 10),
                        PhoneNumber = c.String(nullable: false, maxLength: 15),
                        Email = c.String(nullable: false, maxLength: 50),
                        Status = c.String(nullable: false, maxLength: 15),
                        RecluterUserId = c.Int(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        Created = c.DateTimeOffset(nullable: false, precision: 7),
                        CreatedBy = c.String(nullable: false, maxLength: 10),
                        LastUpdated = c.DateTimeOffset(nullable: false, precision: 7),
                        LastUpdatedBy = c.String(maxLength: 10),
                    })
                .PrimaryKey(t => t.CandidateId)
                .ForeignKey("dbo.RecluterUser", t => t.RecluterUserId, cascadeDelete: true)
                .Index(t => t.RecluterUserId);
            
            CreateTable(
                "dbo.LogMessage",
                c => new
                    {
                        LogMessageId = c.Int(nullable: false, identity: true),
                        Message = c.String(nullable: false, maxLength: 200),
                        ContextKind = c.String(nullable: false, maxLength: 1),
                        Created = c.DateTimeOffset(nullable: false, precision: 7),
                        CreatedBy = c.String(nullable: false, maxLength: 10),
                    })
                .PrimaryKey(t => t.LogMessageId);
            
            CreateTable(
                "dbo.RecluterUser",
                c => new
                    {
                        RecluterUserId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 10),
                        LastName = c.String(nullable: false, maxLength: 10),
                        UserName = c.String(nullable: false, maxLength: 10),
                        Password = c.String(nullable: false, maxLength: 10),
                        Email = c.String(nullable: false, maxLength: 50),
                        IsActive = c.Boolean(nullable: false),
                        Created = c.DateTimeOffset(nullable: false, precision: 7),
                        CreatedBy = c.String(nullable: false, maxLength: 10),
                        LastUpdated = c.DateTimeOffset(nullable: false, precision: 7),
                        LastUpdatedBy = c.String(maxLength: 10),
                    })
                .PrimaryKey(t => t.RecluterUserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Candidate", "RecluterUserId", "dbo.RecluterUser");
            DropIndex("dbo.Candidate", new[] { "RecluterUserId" });
            DropTable("dbo.RecluterUser");
            DropTable("dbo.LogMessage");
            DropTable("dbo.Candidate");
        }
    }
}
