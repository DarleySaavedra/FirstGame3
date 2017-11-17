namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Pregunta", "Respuesta", c => c.String());
            AddColumn("dbo.RegisterViewModel", "Password", c => c.String(nullable: false, maxLength: 100));
        }
        
        public override void Down()
        {
            DropColumn("dbo.RegisterViewModel", "Password");
            DropColumn("dbo.Pregunta", "Respuesta");
        }
    }
}
