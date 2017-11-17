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

        public int contar(int p=0)
        {
            return p++;
        }

        public List<Pregunta> GetPregsCurso(string curso)
        {
            return preg.PreguntaCurso(curso);
        }
        public List<Pregunta> GetPregId(string curso,int id)
        {
            return preg.PreguntaId(curso,id);
        }

    }
}