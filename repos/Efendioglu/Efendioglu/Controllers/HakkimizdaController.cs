using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Efendioglu.Controllers
{
    [Authorize]
    public class HakkimizdaController : Controller
    {
        // GET: Hakkimizda
        public ActionResult Hakkimizda()
        {
            return View();
        }
        public ActionResult iletisim()
        {
            return View();
        } 
        public ActionResult helelo()
        {
            return View();
        }
    }
}
