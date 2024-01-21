using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using Microsoft.Owin.Security.Cookies;
using Microsoft.AspNet.Identity;

[assembly: OwinStartup(typeof(Efendioglu.App_Start.kullanici_config))]

namespace Efendioglu.App_Start
{
    public class kullanici_config
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseCookieAuthentication(new CookieAuthenticationOptions

            {
                AuthenticationType =DefaultAuthenticationTypes.ApplicationCookie,
                LoginPath = new PathString("/Hesap/Login")// burada yetkisiz girişlerde hangi sayfaya geri gideceği yazar bunu ileride değişmen gerekir
            } ); 
              
                

            }

            
            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=316888
        }
    }

