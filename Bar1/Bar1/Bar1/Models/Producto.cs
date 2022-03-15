using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Razor.Generator;

namespace Bar1.Models
{
    public class Producto
    {
        public Producto(String ID,  string nombre, string descripcion, int precio, string img)
        {
            this.ID = ID;
            Nombre = nombre;
            Descripcion = descripcion;
            Precio = precio;
            int Cantidad = 0;
            this.img = img;
        }

        public String ID { get; set; }
        public String Nombre { get; set; }
        public String Descripcion { get; set; }
        public int Precio { get; set; }
        public int Cantidad { get; set; }
        public string img { get; set; }

        //Obtiene el Precio acumulado del producto en base a su cantidad y precio


        public static Producto devolverProductOconId(String id)
        {
            Producto prod = null;
            int i = 0;
            Boolean encontrado = false;
            while (i < Datos.ADProducto.ProductosLista.Count() & encontrado == false)
            {

                prod = Datos.ADProducto.ProductosLista[i];
                if (prod.ID == id)
                {
                    encontrado = true;
                }
                i++;
            }

            return prod;
        }

        public static Producto BuscarNull()
        {
            Producto prod = null;
            for (int i = 0; i < Bar1.Datos.ADProducto.ProductosLista.Count; i++)
            {
                if (Bar1.Datos.ADProducto.ProductosLista[i].ID == null)
                {
                    prod = Bar1.Datos.ADProducto.ProductosLista[i];
                    i = Bar1.Datos.ADProducto.ProductosLista.Count;
                }
                else
                {
                    i++;
                }
            }
            return prod;
        }
            public double Subtotal (int cantidad, double precio)
        {
            double Subtotal = cantidad * precio;
            return Subtotal;
        }
    }


}