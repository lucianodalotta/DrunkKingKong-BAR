using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bar1.Models
{
    public class Pedido
    {
        public Pedido(String Nombre, String Apellido, String Domicilio, String Contacto, String fechaEntrega)
        {
      
            this.Nombre= Nombre;
            this.Apellido = Apellido;
            this.Domicilio = Domicilio;
            this.Contacto = Contacto;
            this.pedidoID = conseguirID();
            this.Fecha = fechaEntrega;
            this.ProductosLista = new List<Producto>();
            foreach (var i in Cliente.ClienteLista) 
            {
                this.ProductosLista.Add(i);
            }
            ;
            this.Total = getTotal();
        }

        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public String Domicilio { get; set; }
        public String Contacto { get; set; }
        public int pedidoID { get; set; }

        public List<Producto> ProductosLista;
        public Boolean Entregado { get; set; }
        public String Fecha { get; set; }
        public double Total { get; set; }
    
        private int conseguirID()
        {
            int max = 0;
            foreach (var item in Bar1.Datos.ADPedido.PedidosLista)
            {

                if (item.pedidoID > max)
                {
                    max = item.pedidoID;
                }

            }
            if (max != 0)
            {
                max++;
            }
            else
            {
                max = 100000;
            }
            return max;
        }

        public static Pedido buscarPedidoPorId(int ID)
        {
            Pedido ped=null;
            int i = 0;
            Boolean encontrado = false;
            while (i < Datos.ADPedido.PedidosLista.Count() & encontrado == false)
            {

                ped = Datos.ADPedido.PedidosLista[i];
                if (ped.pedidoID == ID)
                {
                    encontrado = true;
                }
                else
                {
                    i++;
                }
            }

            return ped;
        }

        public double getTotal()
        {
            Double Total = 0.0;

            foreach (var item in ProductosLista)

            {
                Total = Total + item.Subtotal(item.Cantidad, item.Precio);

            }
            return Total;
        }
    }

   
}
