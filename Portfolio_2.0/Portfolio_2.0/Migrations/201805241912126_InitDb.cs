namespace Portfolio_2._0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Language",
                c => new
                    {
                        LanguageId = c.Int(nullable: false, identity: true),
                        LanguageName = c.String(),
                    })
                .PrimaryKey(t => t.LanguageId);
            
            CreateTable(
                "dbo.PageElement",
                c => new
                    {
                        PageElementId = c.Int(nullable: false, identity: true),
                        PageElementName = c.String(),
                    })
                .PrimaryKey(t => t.PageElementId);
            
            CreateTable(
                "dbo.Project",
                c => new
                    {
                        ProjectId = c.Int(nullable: false, identity: true),
                        ProjectName = c.String(),
                        ImageFileName = c.String(),
                        Visible = c.Boolean(nullable: false),
                        TechnologyId = c.Int(nullable: false),
                        GitHubUrl = c.String(),
                    })
                .PrimaryKey(t => t.ProjectId);
            
            CreateTable(
                "dbo.Technology",
                c => new
                    {
                        TechnologyId = c.Int(nullable: false, identity: true),
                        TechnologyName = c.String(),
                        ImageFileName = c.String(),
                    })
                .PrimaryKey(t => t.TechnologyId);
            
            CreateTable(
                "dbo.Translation",
                c => new
                    {
                        TranslationId = c.Int(nullable: false, identity: true),
                        ObjectId = c.String(),
                        LanguageId = c.Int(nullable: false),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.TranslationId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Translation");
            DropTable("dbo.Technology");
            DropTable("dbo.Project");
            DropTable("dbo.PageElement");
            DropTable("dbo.Language");
        }
    }
}
