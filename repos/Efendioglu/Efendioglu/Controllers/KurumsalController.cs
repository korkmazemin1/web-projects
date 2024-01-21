using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Efendioglu.Models; // modeli kullanmak için burada çağırdık


namespace Efendioglu.Controllers
{
    [Authorize]
    public class KurumsalController : Controller
    {
        // GET: Kurumsal
        public ActionResult Kurumsal()
        {
            

            return View();
        }
    }
}