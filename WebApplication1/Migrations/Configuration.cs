namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<WebApplication1.Models.EFContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WebApplication1.Models.EFContext context)
        {
            context.Pregunta.Add(
                new Models.Pregunta
                {
                    PreguntaId=1,
                    pregunta = " Si 1 kilometro es  igual a 1000 metros, ¿Cuánto metros es 250 kilómetros?",
                    opt1 = " 50 000 metros",
                    opt2 = " 25 000 metros",
                    opt3 = " 250 metros",
                    opt4 = " 250 000 metros",
                    contador = "20"
                });
        }
    }
}
