using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Efendioglu.kullanici
{
    [Authorize]
    public class AdminController : Controller
    {
        private UserManager<kullanici> userManager;

        public AdminController()
        {

            userManager = new UserManager<kullanici>(new UserStore<kullanici>(new kullanici_veri_metin()));

        }
        public ActionResult Index()
        {
            return View(userManager.Users);
        }
    }
}