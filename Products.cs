using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoGina
{
    public class Products
    {
        private int id;
        private string nombre;
        private string imagen;
        private int precio;
        private int existencias;
        private string descripcion;

        public Products(int id, string nombre, string descripcion, int precio, int existencias, string imagen)
        {
            this.id = id;
            this.nombre = nombre;
            this.imagen = imagen;
            this.precio = precio;
            this.existencias = existencias;
            this.descripcion = descripcion;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Imagen { get => imagen; set => imagen = value; }
        public int Precio { get => precio; set => precio = value; }
        public int Existencias { get => existencias; set => existencias = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
    }
}
