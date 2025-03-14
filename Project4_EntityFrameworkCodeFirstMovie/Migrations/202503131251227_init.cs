namespace Project4_EntityFrameworkCodeFirstMovie.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Categories", "MovieId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Categories", "MovieId", c => c.Int(nullable: false));
        }
    }
}
