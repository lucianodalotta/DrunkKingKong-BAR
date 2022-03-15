using Bar1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bar1.Controllers
{
    public class CarritoController : Controller
    {
        //Se Instancia en el ArrayList con productos

        // GET: Carrito
 
        public ActionResult Index()
        {
            if (Cliente.getTotal() == 0)
            {

                return RedirectToAction("Index", "Cocteles");
            }
            else
            {
                return View();
            }
        }

        public ActionResult Remover(String id)
        {
            Producto prod = Cliente.buscarProductoPorId(id);

            if (prod != null)
            {
                if (prod.Cantidad > 1)
                {
                    prod.Cantidad--;
                }
                else
                {
                    prod.Cantidad--;
                    Cliente.ClienteLista.Remove(prod);
                }
            }

            return RedirectToAction("Index", "Carrito");
        }
        public ActionResult Limpiar()
        {
            Cliente.ClienteLista.Clear();
            

            return RedirectToAction("Index", "Carrito");
        }
    }
}