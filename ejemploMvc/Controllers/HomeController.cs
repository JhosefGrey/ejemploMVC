using ejemploMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ejemploMvc.Controllers
{
    public class HomeController : Controller
    {


        public ActionResult Index()
        {

            List<productoModel> productos = new List<productoModel>();
            Random random = new Random();

            string[] nombres = new string[]
            {
            "Producto A", "Producto B", "Producto C", "Producto D", "Producto E",
            "Producto F", "Producto G", "Producto H", "Producto I", "Producto J"
            };

            for (int i = 0; i < 10; i++)
            {
                productos.Add(new productoModel
                {
                    Id = Guid.NewGuid(),
                    Nombre = nombres[random.Next(nombres.Length)],
                    Precio = (decimal)(random.Next(1000, 30001) / 100.0)
                });
            }

            Session["products"] = productos;

            return View();
        }


        public ActionResult Buscar(string nombre)
        {

            var data = getProductos(nombre);
            return PartialView("_Buscar", data);
        }


        public ActionResult Inicio()
        {
            var productos = Session["products"] as List<productoModel>;
            return PartialView("_Buscar", productos);
        }


        public List<productoModel> getProductos(string nombre)
        {
            var productos = Session["products"] as List<productoModel>;

            return productos.Where(x => x.Nombre.ToUpper().Contains(nombre.ToUpper())).ToList();
        }
    }
}