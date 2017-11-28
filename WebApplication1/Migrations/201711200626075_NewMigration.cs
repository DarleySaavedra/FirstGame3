namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "score", c => c.Int());
            DropColumn("dbo.Pregunta", "score");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Pregunta", "score", c => c.Int());
            DropColumn("dbo.RegisterViewModel", "score");
        }
    }
}
