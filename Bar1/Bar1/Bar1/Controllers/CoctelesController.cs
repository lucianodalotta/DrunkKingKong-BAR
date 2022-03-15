using Bar1.Datos;
using Bar1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bar1.Controllers
{
    public class CoctelesController : Controller
    {
        // GET: Cocteles
        public ActionResult Index()
        {
            return View(ADProducto.ProductosLista);
        }


        public ActionResult Comprar(String ID)
        {
            Producto producto = Producto.devolverProductOconId(ID);
            Bar1.Models.Cliente.AgregarProducto(producto);
            return RedirectToAction("Index", "Carrito");
        }

    }
}