using Bar1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bar1.Controllers
{
    public class ConfirmaController : Controller
    {
        // GET: Confirma
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Cancelar()
        {
            return RedirectToAction("Index", "Carrito");
        }


        public ActionResult Confirmar (String Nombre, String Apellido, String Domicilio, String Contacto, String Fecha)
        {
            Pedido ped = new Pedido(Nombre, Apellido, Domicilio, Contacto, Fecha);
            Bar1.Datos.ADPedido.PedidosLista.Add(ped);
            Bar1.Models.Cliente.ClienteLista.Clear();
            return RedirectToAction("Index", "Home");
        }
    }
}