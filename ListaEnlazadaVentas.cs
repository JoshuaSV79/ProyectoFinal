using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoGina
{
    using System.Collections.Generic;

    public class NodoVenta
    {
        public double Monto { get; set; }
        public NodoVenta Siguiente { get; set; }

        public NodoVenta(double monto)
        {
            Monto = monto;
            Siguiente = null;
        }
    }

    public class ListaEnlazadaVentas
    {
        private NodoVenta cabeza;

        public ListaEnlazadaVentas()
        {
            cabeza = null;
        }

        // Método para agregar una venta
        public void AgregarVenta(double monto)
        {
            NodoVenta nuevoNodo = new NodoVenta(monto);
            if (cabeza == null)
            {
                cabeza = nuevoNodo;
            }
            else
            {
                NodoVenta actual = cabeza;
                while (actual.Siguiente != null)
                {
                    actual = actual.Siguiente;
                }
                actual.Siguiente = nuevoNodo;
            }
        }

        // Calcular el total de las ventas
        public double CalcularTotalVentas()
        {
            double total = 0;
            NodoVenta actual = cabeza;
            while (actual != null)
            {
                total += actual.Monto;
                actual = actual.Siguiente;
            }
            return total;
        }

        // Contar el número de ventas
        public int ContarVentas()
        {
            int contador = 0;
            NodoVenta actual = cabeza;
            while (actual != null)
            {
                contador++;
                actual = actual.Siguiente;
            }
            return contador;
        }

        // Obtener montos individuales
        public List<double> ObtenerMontos()
        {
            List<double> montos = new List<double>();
            NodoVenta actual = cabeza;
            while (actual != null)
            {
                montos.Add(actual.Monto);
                actual = actual.Siguiente;
            }
            return montos;
        }
    }

}
