using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Servicios
{
    public interface IPreguntaServices
    {
        List<Pregunta> ReadPreg();
        List<Pregunta> GetPregsCurso(string curso);
        List<Pregunta> GetPregId(string curso, int id);
    }
}
