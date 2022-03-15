using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;

namespace Bar1.Models
{
    public class Cliente
    {

        public String ID { get; set; }

        public String Nombre { get; set; }

        public String DNI { get; set; }

        public String Direccion { get; set; }

        public static List<Producto> ClienteLista = new List<Producto>();

        public static double Total { get; set; } = 0;



        //busca un producto en el carrito por ID
        public static Boolean buscarId(String id)
        {
            Producto prod;
            int i = 0;
            Boolean encontrado = false;
            while (i < ClienteLista.Count() & encontrado == false)
            {

                prod = ClienteLista[i];
                if (prod.ID == id)
                {
                    encontrado = true;
                }
                i++;
            }

            return encontrado;
        }

        public static Producto buscarProductoPorId(String id)
        {
            Producto prod=null;
            int i = 0;
            Boolean encontrado = false;
            while (i < ClienteLista.Count() & encontrado == false)
            {

                prod = ClienteLista[i];
                if (prod.ID == id)
                {
                    encontrado = true;
                }
                    i++;
            }

            return prod;
        }

        //Busca si un producto ya está en el carrito, si no lo encuentra lo agrega, sino tan solo le suma a su cantidad
        public static void AgregarProducto(Producto prod)
        {
            if (buscarId(prod.ID))
            {
                prod.Cantidad++;
            }
            else
            {
                Bar1.Models.Cliente.ClienteLista.Add(prod);
                prod.Cantidad=1;
            }
    
        }

        ////Elimina un producto del carrito, si no queda más cantidad, lo elimina
        public void QuitarCarrito(Producto prod)
        {
            prod.Cantidad--;
            if (prod.Cantidad <= 0)
            {
                Bar1.Models.Cliente.ClienteLista.Remove(prod);
                prod.Cantidad = 0;
            }
        }

        //Obtiene el precio total de los productos en el carrito
        public static double getTotal()
        {
            Double Total = 0.0;

            foreach(var item in ClienteLista)
            
            {
                Total = Total + item.Subtotal(item.Cantidad,item.Precio);

            }
            return Total;
        }

    }
}