using WebApplication1.Servicios;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;

namespace WebApplication1.Controllers
{
    public class MateController : Controller
    {
        IPreguntaServices pregres;

        public MateController()
        {
            pregres = new PreguntaService();
        }
        // GET: Mate
        public ActionResult Index(int? pagina)
        {
            int pagtam = 1;
            int numpag = pagina ?? 1;
            var list = pregres.ReadPreg();
            return View(list.ToPagedList(numpag, pagtam));
        }

    }
}
