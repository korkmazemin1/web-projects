using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Efendioglu.Controllers
{
    [Authorize]
    public class AnasayfaController : Controller
    {
        // GET: Home
        // anadizine gitmeden önce önüne log in engeli koyduk
        public ViewResult index()// komutları yerine getirir// string yerinde return ile dönen değerin tipi yazmalı
        {
            return View() ;// return ile değeri giriyor
           
        }



    }
}