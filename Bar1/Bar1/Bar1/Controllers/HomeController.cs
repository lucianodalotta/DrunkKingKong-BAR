using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using Bar1.Datos;
using Bar1.Models;

namespace Bar1.Controllers
{
    public class HomeController : Controller
    {



        // GET: Home
        public ActionResult Index()
        {


            //return View("Index");
            return View(ADProducto.ProductosLista);
        }
        public ActionResult Login()
        {

            return View();
        }
        public ActionResult Admin()
        {   if (Session["AdminLogueado"]==null)
            {

                return RedirectToAction("Login", "Home");
            }
            else
            {
                ViewBag.AdminLogueado = Session["AdminLogueado"];
                return View(ADProducto.ProductosLista);
            }
        }
        public ActionResult Entregar (int ID)
        {
            Pedido ped = Pedido.buscarPedidoPorId(ID);
            ped.Entregado= true;
            return RedirectToAction("Admin", "Home");
        }
        public ActionResult Ingresar(String usuario, String pass)
        {
            Boolean Ingreso = false;

            Admin AdminIngreso = new Admin(usuario, pass);

            for (int i = 0; i < @Bar1.Datos.ADAdmin.AdminLista.Count; i++)
            {
                if (AdminIngreso.Usuario == Bar1.Datos.ADAdmin.AdminLista[i].Usuario)
                {
                    if (AdminIngreso.Pass == Bar1.Datos.ADAdmin.AdminLista[i].Pass)
                    {
                        Ingreso = true;

                        Session["AdminLogueado"] = AdminIngreso;
                    }
                }
            }
            if (Ingreso)
            {
                return RedirectToAction("Admin", "Home");
            }
            else
            {


                return RedirectToAction("Login", "Home");
            }

        }
        public ActionResult Comprar(String ID)
        {
            if (ID==null)
            {
            }
            else {
                Producto producto = Producto.devolverProductOconId(ID);
                Bar1.Models.Cliente.AgregarProducto(producto); }
            return RedirectToAction("Index", "Carrito");
        }
        public ActionResult ADAgregarProducto(String ID, String Nombre,String Descripcion,int Precio,String Img)
        {
            Producto prod= new Producto(ID, Nombre, Descripcion, Precio, Img);

            if (Producto.BuscarNull()!=null)
                
            {
                Bar1.Datos.ADProducto.ProductosLista.Remove(Producto.BuscarNull());
                Bar1.Datos.ADProducto.ProductosLista.Add(prod);
            }
            else
            {
                Bar1.Datos.ADProducto.ProductosLista.Add(prod);

            }
            return RedirectToAction("Admin", "Home");
        }
        public ActionResult ADBorrarProducto(String ID)
        {
            Producto producto = Producto.devolverProductOconId(ID);
            if (Bar1.Datos.ADProducto.ProductosLista.Count <= 4)
            {
                Bar1.Datos.ADProducto.ProductosLista.Remove(producto);
                Bar1.Datos.ADProducto.ProductosLista.Add(new Producto(null, null, null, 0, null));
            }
            else
            {
                Bar1.Datos.ADProducto.ProductosLista.Remove(producto);

            }
            return RedirectToAction("Admin", "Home");
        }
    }
}
