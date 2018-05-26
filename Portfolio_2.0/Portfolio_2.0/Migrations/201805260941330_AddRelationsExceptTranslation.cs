namespace Portfolio_2._0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRelationsExceptTranslation : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.PageElement");
            DropPrimaryKey("dbo.Project");
            DropPrimaryKey("dbo.Technology");
            AddColumn("dbo.Project", "Technology_TechnologyName", c => c.String(maxLength: 128));
            AddColumn("dbo.Translation", "Language_LanguageId", c => c.Int());
            AlterColumn("dbo.PageElement", "PageElementId", c => c.Int(nullable: false));
            AlterColumn("dbo.PageElement", "PageElementName", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Project", "ProjectId", c => c.Int(nullable: false));
            AlterColumn("dbo.Project", "ProjectName", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Technology", "TechnologyId", c => c.Int(nullable: false));
            AlterColumn("dbo.Technology", "TechnologyName", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.PageElement", "PageElementName");
            AddPrimaryKey("dbo.Project", "ProjectName");
            AddPrimaryKey("dbo.Technology", "TechnologyName");
            CreateIndex("dbo.Project", "Technology_TechnologyName");
            CreateIndex("dbo.Translation", "Language_LanguageId");
            AddForeignKey("dbo.Project", "Technology_TechnologyName", "dbo.Technology", "TechnologyName");
            AddForeignKey("dbo.Translation", "Language_LanguageId", "dbo.Language", "LanguageId");
            DropColumn("dbo.Project", "TechnologyId");
            DropColumn("dbo.Translation", "LanguageId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Translation", "LanguageId", c => c.Int(nullable: false));
            AddColumn("dbo.Project", "TechnologyId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Translation", "Language_LanguageId", "dbo.Language");
            DropForeignKey("dbo.Project", "Technology_TechnologyName", "dbo.Technology");
            DropIndex("dbo.Translation", new[] { "Language_LanguageId" });
            DropIndex("dbo.Project", new[] { "Technology_TechnologyName" });
            DropPrimaryKey("dbo.Technology");
            DropPrimaryKey("dbo.Project");
            DropPrimaryKey("dbo.PageElement");
            AlterColumn("dbo.Technology", "TechnologyName", c => c.String());
            AlterColumn("dbo.Technology", "TechnologyId", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Project", "ProjectName", c => c.String());
            AlterColumn("dbo.Project", "ProjectId", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.PageElement", "PageElementName", c => c.String());
            AlterColumn("dbo.PageElement", "PageElementId", c => c.Int(nullable: false, identity: true));
            DropColumn("dbo.Translation", "Language_LanguageId");
            DropColumn("dbo.Project", "Technology_TechnologyName");
            AddPrimaryKey("dbo.Technology", "TechnologyId");
            AddPrimaryKey("dbo.Project", "ProjectId");
            AddPrimaryKey("dbo.PageElement", "PageElementId");
        }
    }
}
