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

        public int contar(Pregunta p)
        {
            var s = int.Parse(p.contador);
            while (s != 0)
            {
                s--;               
            }
            return s;
            
        }

        public List<Pregunta> GetPregsCurso(string curso)
        {
            return preg.PreguntaCurso(curso);
        }
    }
}