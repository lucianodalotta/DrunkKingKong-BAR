using Bar1.Datos;
using Bar1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Bar1
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);


            //LOS PRODUCTOS
            Producto producto1 = new Producto (
                "01",
                "Message In a Bottle", 
                "Flaming Sour: Limón, azúcar y Fuego. Al líquido se le prende una ligera llama en la superficie. El fuego quema el exceso de alcohol y suaviza el sabor.",
                420,
                "https://www.thespruceeats.com/thmb/Vh9Ari_ojFCPvKtb1D5rIqqh2ZA=/3828x3828/smart/filters:no_upscale()/_kamikaze-cocktail-recipe-759313-hero-5bb7c7e846e0fb0051ee4eb4.jpg" 
            );

            Producto producto2 = new Producto(
                "02",
                "Modern Love",
                "Descripcion del producto siendo observado en este instante",
                500,
                "https://hips.hearstapps.com/del.h-cdn.co/assets/15/38/1442432590-delish-halloween-cocktails-sweet-poison.png"
         );

            Producto producto3 = new Producto (
                 "03", 
                "Isla Bonita", 
                "Sunrise: Jugo de naranja y uvas. Un trago que se hace en la licuadora. Hielo y frutas se procesan hasta formar un granizado.", 
                350, 
                "https://www.liquor.com/thmb/5AXwkLkr2OUx8DufiZv3jSIVoYQ=/735x0/hurricane-720x720-primary-e5b3f57f86904ad39f87c96b1b0e0d1e.jpg"
          );

            Producto producto4 = new Producto (  "04", 
                "Persiana americana", 
                "Descripcion del producto siendo observado en este instante", 
                250,  
                "https://miro.medium.com/max/10020/0*pVTtTdJA65mVudPx");

            Producto producto5 = new Producto (
                 "05", 
                "Let's Dance", 
                "Descripcion del producto siendo observado en este instante", 
                650, 
                "https://images.unsplash.com/photo-1536935338788-846bb9981813?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&w=1000&q=80" );

            Producto producto6 = new Producto ( 
                 "06", 
                "lets get physical", 
                "Descripcion del producto siendo observado en este instante", 
                450, 
                 "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcSbVbPSZRS0gtl_V4GrkhDth44Ve0e1cdgELQ&usqp=CAU");

            Producto producto7 = new Producto(
                 "07",
                "Sweet Child O Mine",
                "Descripcion del producto siendo observado en este instante",
                550,
                "https://www.liquor.com/thmb/kO-FvjQRKYrxavGfUFmYvQcUY8k=/735x0/__opt__aboutcom__coeus__resources__content_migration__liquor__2018__10__19111600__drunk-uncle-720x720-recipe-dd27910793b847c3921cf543dcab9bb9.jpg");
            Producto producto8 = new Producto (
                 "08",
                "Polybius", 
                "Descripcion del producto siendo observado en este instante",
                600, 
                "https://i.insider.com/5c2f4534ad9571412a2cb0c3?width=1067&format=jpeg");

            //SE METEN LOS PRODUCTOS
            ADProducto.ProductosLista.Add(producto1);
            ADProducto.ProductosLista.Add(producto2);
            ADProducto.ProductosLista.Add(producto3);
            ADProducto.ProductosLista.Add(producto4);
            ADProducto.ProductosLista.Add(producto5);
            ADProducto.ProductosLista.Add(producto6);
            ADProducto.ProductosLista.Add(producto7);
            ADProducto.ProductosLista.Add(producto8);

            //SE METE EL ADMIN}
            //EL ADMIN 
            Admin Master = new Admin("Admin", "123");
            ADAdmin.AdminLista.Add(Master);

            //ALGUNOS PRODUCTOS EN EL CARRITO DE PRUEBA 
            //Bar1.Models.Cliente.AgregarProducto(producto1);
            //Bar1.Models.Cliente.AgregarProducto(producto1);
            //Bar1.Models.Cliente.AgregarProducto(producto2);

            //Pedidos Agregados de prueba

           // Pedido pedido1 = new Pedido(
           //      "Pepe", "Portoto",
          //    "Patata 123", "12-1231-1234", "12/12/1991"
         //   );

          //  Bar1.Datos.ADPedido.PedidosLista.Add(pedido1);
            
            
          //  Pedido pedido2 = new Pedido(
          //      "Pepe", "Portoto",
          //    "Patata 123", "12-1231-1234", "12/12/1991"
         // );

         //   Bar1.Datos.ADPedido.PedidosLista.Add(pedido2);
         //   Pedido pedido3 = new Pedido(
        //      "Pepe","Portoto",
        //      "Patata 123", "12-1231-1234", "12/12/1991"
        //  );

        //
        //    Bar1.Datos.ADPedido.PedidosLista.Add(pedido3);

     }
  }
}
