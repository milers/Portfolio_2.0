namespace Portfolio_2._0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModelCorrection : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Project", "Technology_TechnologyName", "dbo.Technology");
            DropIndex("dbo.Project", new[] { "Technology_TechnologyName" });
            DropPrimaryKey("dbo.PageElement");
            DropPrimaryKey("dbo.Project");
            DropPrimaryKey("dbo.Technology");
            AddColumn("dbo.Project", "Technology_TechnologyId", c => c.Int());
            AddPrimaryKey("dbo.PageElement", new[] { "PageElementId", "PageElementName" });
            AddPrimaryKey("dbo.Project", new[] { "ProjectId", "ProjectName" });
            AddPrimaryKey("dbo.Technology", new[] { "TechnologyId", "TechnologyName" });
            CreateIndex("dbo.Project", new[] { "Technology_TechnologyId", "Technology_TechnologyName" });
            AddForeignKey("dbo.Project", new[] { "Technology_TechnologyId", "Technology_TechnologyName" }, "dbo.Technology", new[] { "TechnologyId", "TechnologyName" });
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Project", new[] { "Technology_TechnologyId", "Technology_TechnologyName" }, "dbo.Technology");
            DropIndex("dbo.Project", new[] { "Technology_TechnologyId", "Technology_TechnologyName" });
            DropPrimaryKey("dbo.Technology");
            DropPrimaryKey("dbo.Project");
            DropPrimaryKey("dbo.PageElement");
            DropColumn("dbo.Project", "Technology_TechnologyId");
            AddPrimaryKey("dbo.Technology", "TechnologyName");
            AddPrimaryKey("dbo.Project", "ProjectName");
            AddPrimaryKey("dbo.PageElement", "PageElementName");
            CreateIndex("dbo.Project", "Technology_TechnologyName");
            AddForeignKey("dbo.Project", "Technology_TechnologyName", "dbo.Technology", "TechnologyName");
        }
    }
}
