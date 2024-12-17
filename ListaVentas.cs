using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoGina
{
    public class ListaVentas
    {
        private Venta head;

        // Método para agregar una venta a la lista
        public void AgregarVenta(Venta nuevaVenta)
        {
            if (head == null)
                head = nuevaVenta;
            else
            {
                Venta actual = head;
                while (actual.Siguiente != null)
                    actual = actual.Siguiente;

                actual.Siguiente = nuevaVenta;
            }
        }

        // Método para contar el número de ventas
        public int ContarVentas()
        {
            int contador = 0;
            Venta actual = head;

            while (actual != null)
            {
                contador++;
                actual = actual.Siguiente;
            }

            return contador;
        }

        // Obtener todas las ventas como lista
        public List<Venta> ObtenerVentas()
        {
            List<Venta> ventas = new List<Venta>();
            Venta actual = head;

            while (actual != null)
            {
                ventas.Add(actual);
                actual = actual.Siguiente;
            }

            return ventas;
        }
    }

}
