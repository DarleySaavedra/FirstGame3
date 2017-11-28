using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using WebApplication1.Servicios;
using System.Web.UI.WebControls;
using System.Threading.Tasks;
using System.Threading;

namespace WebApplication1.Controllers
{
    [Authorize]
    public class ComuController : Controller
    {
        
        IPreguntaServices pregres;
        public ComuController()
        {
            pregres = new PreguntaService();
        }
        // GET: Mate

        //public async Task<ActionResult> Index(int? id)
        //{
        //    string cr = "Comunicacion";
        //    int dx = await nextButton(id);
        //    if (id == null)
        //    {
        //        dx = 0;
        //    }
        //    var list = pregres.GetPregsCurso(cr);
        //    var lt = list.ElementAt(dx);
        //    return View(lt);
        //}

        //public async Task<int> nextButton(int? id)
        //{
        //    id = 0;
        //    return await Task.Run(() =>
        //    {
        //        Thread.Sleep(1000);
        //        return (int)id++;
        //    }
        //);
        //}
      
        public async Task<ActionResult> Index(int?idx,int? score)
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
            string curso = "Comunicacion";
            var list = pregres.GetPregsCurso(curso);
            var lt = list.ElementAt((int)idx);
            return View(lt);
        }
    }
}
