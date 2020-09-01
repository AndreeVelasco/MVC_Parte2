using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVC_Parte2
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "BuscarProducto",
                url: "BuscarProducto/{nombreProducto}",
                defaults: new { controller = "Productos", action = "BuscarProducto", nombreProducto = ""}
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Productos", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
