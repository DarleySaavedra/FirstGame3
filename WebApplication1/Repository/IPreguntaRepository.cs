using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Repository
{
    interface IPreguntaRepository : IRepository<Pregunta>
    {
        List<Pregunta> PreguntaCurso(string curso);
    }
}
