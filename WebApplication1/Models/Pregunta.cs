using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Pregunta
    {
        public int PreguntaId { get; set; }
        public string pregunta { get; set; }
        public string opt1 { get; set; }
        public string opt2 { get; set; }
        public string opt3 { get; set; }
        public string opt4 { get; set; }
        public string contador { get; set; }
        public string Respuesta { get; set; }
    }
}