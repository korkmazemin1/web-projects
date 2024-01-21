using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet;
using Efendioglu.kullanici;
using Microsoft.AspNet.Identity.EntityFramework;
using Efendioglu.Models;
using Microsoft.Owin.Security;
using Microsoft.Extensions.Logging;

namespace Efendioglu.kullanici
{
    [Authorize]
    public class HesapController : Controller
    {

        // GET: Hesap
        private UserManager<kullanici> userManager;

        public HesapController()
        {

            userManager = new UserManager<kullanici>(new UserStore<kullanici>(new kullanici_veri_metin()));

        }
        [AllowAnonymous]//giriş yapmadan register sayfasına erişimi sağlar
        public ActionResult Register()

        {
            return View();
               
                }
        [HttpPost]
        [ValidateAntiForgeryToken]//koruma amacı ile eklenir
        [AllowAnonymous]//giriş yapmadan register sayfasına erişimi sağlar
        public ActionResult Register(Register model)

        {
            if (ModelState.IsValid)
            {
                var kullanici = new kullanici();
                kullanici.UserName = model.Username;
                kullanici.Email = model.Email;

                var result = userManager.Create(kullanici, model.password);
                if (result.Succeeded)
                {
                    return RedirectToAction("Login");// burada başarılı giriş sonucu logine iletim sözkonusu

                }
                else
                {
                    foreach(var error in result.Errors)
                    {
                        ModelState.AddModelError("",error);// hata mesajlarını gösteriri
                    }
                }

            }

            return View(model);

        }
        [AllowAnonymous]//giriş yapmadan register sayfasına erişimi sağlar
        [HttpGet]
        public ActionResult Login()
        {

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [AllowAnonymous]
        public ActionResult Login(LoginModel model,string returnUrl)
        {
            if (ModelState.IsValid) { 
            var kullanici = userManager.Find(model.Username, model.password);

            if (kullanici == null)
            {
                ModelState.AddModelError("", "Yanlış kullanıcı adı veya parola");
            }
            else
            {
                var authManager = HttpContext.GetOwinContext().Authentication;
                var identity = userManager.CreateIdentity(kullanici, "ApplicationCookie");
                var authProperties = new AuthenticationProperties()
                {
                    IsPersistent=true// beni hatırlar kısmı
                };
                authManager.SignOut();
                authManager.SignIn(authProperties,identity);
                return Redirect(string.IsNullOrEmpty(returnUrl) ? "/Anasayfa/index":returnUrl);
                }
            }
            ViewBag.returnUrl = returnUrl;

            return View(model);
        }
        public ActionResult Logout()
        {
            var authManager = HttpContext.GetOwinContext().Authentication;
            authManager.SignOut();
            return RedirectToAction("Login", "Hesap");
        }
        public ActionResult Index()
        {
            return View();
        }
    }
}