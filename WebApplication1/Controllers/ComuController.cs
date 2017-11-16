using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using WebApplication1.Servicios;
using System.Web.UI.WebControls;

namespace WebApplication1.Controllers
{
    public class ComuController : Controller
    {
        IPreguntaServices pregres;

        public ComuController()
        {
            pregres = new PreguntaService();
        }
        // GET: Mate
        [HttpGet]
        public ActionResult Index(int? pagina)
        {
            string curso = "Comunicacion";
            int pagtam = 1;
            int numpag = pagina ?? 1;
            var list = pregres.GetPregsCurso(curso);
            
            return View(list.ToPagedList(numpag, pagtam));
        }
        [HttpPost]
        public ActionResult Index(int id)
        {
            return View();
        }
    }
}
