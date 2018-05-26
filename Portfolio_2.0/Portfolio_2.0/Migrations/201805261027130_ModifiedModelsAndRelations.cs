namespace Portfolio_2._0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifiedModelsAndRelations : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Translation", "Language_LanguageId", "dbo.Language");
            DropIndex("dbo.Translation", new[] { "Language_LanguageId" });
            RenameColumn(table: "dbo.Translation", name: "Language_LanguageId", newName: "LanguageId");
            AddColumn("dbo.Project", "TechnologyId", c => c.Int(nullable: false));
            AlterColumn("dbo.Translation", "LanguageId", c => c.Int(nullable: false));
            CreateIndex("dbo.Translation", "LanguageId");
            AddForeignKey("dbo.Translation", "LanguageId", "dbo.Language", "LanguageId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Translation", "LanguageId", "dbo.Language");
            DropIndex("dbo.Translation", new[] { "LanguageId" });
            AlterColumn("dbo.Translation", "LanguageId", c => c.Int());
            DropColumn("dbo.Project", "TechnologyId");
            RenameColumn(table: "dbo.Translation", name: "LanguageId", newName: "Language_LanguageId");
            CreateIndex("dbo.Translation", "Language_LanguageId");
            AddForeignKey("dbo.Translation", "Language_LanguageId", "dbo.Language", "LanguageId");
        }
    }
}
