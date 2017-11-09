namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPregunta : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.RegisterViewModel",
                c => new
                    {
                        RegisterViewModelId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.RegisterViewModelId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.RegisterViewModel");
        }
    }
}
