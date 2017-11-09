 using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;
using WebApplication1.Repository;

namespace WebApplication1.Servicios
{
    public class PreguntaService : IPreguntaServices
    {
        IPreguntaRepository preg;

        public PreguntaService()
        {
            preg = new PreguntaRepository();
        }
        public List<Pregunta> ReadPreg()
        {
            return preg.Reader();
        }
    }
}