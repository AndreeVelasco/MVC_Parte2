using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Parte2.Controllers
{
    public class ProductosController : Controller
    {
        // GET: Productos
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult BuscarProducto()
        {
            string nombreProducto = RouteData.Values["nombreProducto"].ToString();
            nombreProducto = Server.HtmlEncode(nombreProducto);
            string resultado = string.Empty;
            switch(nombreProducto)
            {
                case "PC":
                    {
                        resultado = "Disponible 4 unidades.";
                        break;
                    }
                case "RAM":
                    {
                        resultado = "Disponible 2 unidades.";
                        break;
                    }
                default:
                    {
                        resultado = string.Format("El producto {0} no existe en stock", nombreProducto);
                        break;
                    }
            }
            return Content("<p>" + resultado + "</p>");
        }
    }
}