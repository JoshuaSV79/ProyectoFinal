using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoGina
{
    
        public class Venta
        {
            public int ID { get; set; } // ID único de la venta
            public string Usuario { get; set; } // Usuario que realizó la venta
            public DateTime Fecha { get; set; } // Fecha y hora de la venta
            public List<Producto> Productos { get; set; } = new List<Producto>(); // Lista de productos
            public decimal Total
            {
                get
                {
                    return Productos.Sum(p => p.Subtotal); // Calcula el total de la venta
                }
            }
            public Venta Siguiente { get; set; } // Referencia al siguiente nodo
        }

    }

