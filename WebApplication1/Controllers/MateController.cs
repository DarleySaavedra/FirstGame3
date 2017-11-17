using System;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using WebApplication1.Models;
using WebApplication1.Servicios;

namespace WebApplication1.Controllers
{
    [Authorize]
    public class MateController : Controller
    {
        IPreguntaServices pregres;
        
        
        public MateController()
        {
            pregres = new PreguntaService();
        }

        
        public ActionResult Index(int? idx, int? score)
        {
            if (idx == null)
            {
                idx = 0;
            }
            if (score == null)
            {
                score = 0;
            }
            ViewBag.dx = idx;
            ViewBag.score = score;
            string curso = "Matematica";
            var list = pregres.GetPregsCurso(curso);
            var lt = list.ElementAt((int)idx);
            return View(lt);
        }

    }
}
