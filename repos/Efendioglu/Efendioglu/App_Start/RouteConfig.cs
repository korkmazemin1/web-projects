using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Efendioglu
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",//girilecek url burada sırasıyla controller/action
                defaults: new { controller = "Hesap", action = "Login", id = UrlParameter.Optional }// burada default ile home controllera gidileceği belirtilir
            //eğer tarayıcıya /yapi yazarsan yapi açılır ancak default olarak h 
                );
            
        }
    }
}
