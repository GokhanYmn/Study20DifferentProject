namespace Project4_EntityFrameworkCodeFirstMovie.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mi2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Categories", "MovieId", c => c.Int(nullable: false));
            AddColumn("dbo.Movies", "CategoryId", c => c.Int(nullable: false));
            CreateIndex("dbo.Movies", "CategoryId");
            AddForeignKey("dbo.Movies", "CategoryId", "dbo.Categories", "CategoryId", cascadeDelete: true);
            DropColumn("dbo.Movies", "Category");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movies", "Category", c => c.String());
            DropForeignKey("dbo.Movies", "CategoryId", "dbo.Categories");
            DropIndex("dbo.Movies", new[] { "CategoryId" });
            DropColumn("dbo.Movies", "CategoryId");
            DropColumn("dbo.Categories", "MovieId");
        }
    }
}
