namespace Portfolio_2._0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovedKeys : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Project", new[] { "Technology_TechnologyId", "Technology_TechnologyName" }, "dbo.Technology");
            DropIndex("dbo.Project", new[] { "Technology_TechnologyId", "Technology_TechnologyName" });
            DropColumn("dbo.Project", "TechnologyId");
            RenameColumn(table: "dbo.Project", name: "Technology_TechnologyId", newName: "TechnologyId");
            DropPrimaryKey("dbo.PageElement");
            DropPrimaryKey("dbo.Project");
            DropPrimaryKey("dbo.Technology");
            AlterColumn("dbo.PageElement", "PageElementId", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.PageElement", "PageElementName", c => c.String());
            AlterColumn("dbo.Project", "ProjectId", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Project", "ProjectName", c => c.String());
            AlterColumn("dbo.Project", "TechnologyId", c => c.Int(nullable: false));
            AlterColumn("dbo.Technology", "TechnologyId", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Technology", "TechnologyName", c => c.String());
            AddPrimaryKey("dbo.PageElement", "PageElementId");
            AddPrimaryKey("dbo.Project", "ProjectId");
            AddPrimaryKey("dbo.Technology", "TechnologyId");
            CreateIndex("dbo.Project", "TechnologyId");
            AddForeignKey("dbo.Project", "TechnologyId", "dbo.Technology", "TechnologyId", cascadeDelete: true);
            DropColumn("dbo.Project", "Technology_TechnologyName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Project", "Technology_TechnologyName", c => c.String(maxLength: 128));
            DropForeignKey("dbo.Project", "TechnologyId", "dbo.Technology");
            DropIndex("dbo.Project", new[] { "TechnologyId" });
            DropPrimaryKey("dbo.Technology");
            DropPrimaryKey("dbo.Project");
            DropPrimaryKey("dbo.PageElement");
            AlterColumn("dbo.Technology", "TechnologyName", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Technology", "TechnologyId", c => c.Int(nullable: false));
            AlterColumn("dbo.Project", "TechnologyId", c => c.Int());
            AlterColumn("dbo.Project", "ProjectName", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Project", "ProjectId", c => c.Int(nullable: false));
            AlterColumn("dbo.PageElement", "PageElementName", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.PageElement", "PageElementId", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Technology", new[] { "TechnologyId", "TechnologyName" });
            AddPrimaryKey("dbo.Project", new[] { "ProjectId", "ProjectName" });
            AddPrimaryKey("dbo.PageElement", new[] { "PageElementId", "PageElementName" });
            RenameColumn(table: "dbo.Project", name: "TechnologyId", newName: "Technology_TechnologyId");
            AddColumn("dbo.Project", "TechnologyId", c => c.Int(nullable: false));
            CreateIndex("dbo.Project", new[] { "Technology_TechnologyId", "Technology_TechnologyName" });
            AddForeignKey("dbo.Project", new[] { "Technology_TechnologyId", "Technology_TechnologyName" }, "dbo.Technology", new[] { "TechnologyId", "TechnologyName" });
        }
    }
}
