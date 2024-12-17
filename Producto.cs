using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoGina
{
    public class Producto
    {
        public int ID { get; set; }         // ID único del producto
        public string Nombre { get; set; } // Nombre del producto
        public int Cantidad { get; set; }  // Cantidad vendida
        public decimal Precio { get; set; } // Precio unitario
        public decimal Subtotal
        {
            get
            {
                return Cantidad * Precio; // Subtotal por producto
            }
        }
    }

}
