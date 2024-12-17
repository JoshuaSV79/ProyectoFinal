using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoGina
{
    public partial class Grafica : Form
    {
        private List<(string Producto, int Cantidad)> datos;

        public Grafica()
        {
            InitializeComponent();
            // Cargar los datos para la gráfica
            datos = ObtenerDatosParaGrafica();
        }

        // Simulación de datos para la gráfica
        private List<(string Producto, int Cantidad)> ObtenerDatosParaGrafica()
        {
            return new List<(string, int)>
            {
                ("Producto A", 15),
                ("Producto B", 30),
                ("Producto C", 25),
                ("Producto D", 40)
            };
        }

        // Evento de Paint para dibujar la gráfica
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;

            // Establecer fuente y colores para el gráfico
            Font font = new Font("Arial", 10);
            Pen pen = new Pen(Color.Black, 2);
            Brush brush = new SolidBrush(Color.Blue);

            int x = 50; // Posición inicial en X
            int y = 200; // Posición en Y para la base
            int barWidth = 50; // Ancho de cada barra
            int maxHeight = 150; // Altura máxima para las barras

            // Encontrar el valor máximo para normalizar las barras
            int maxValue = Math.Max(1, datos.Max(d => d.Cantidad));

            // Dibujar cada barra
            foreach (var dato in datos)
            {
                // Normalizar la altura de la barra según el valor
                int barHeight = (int)((float)dato.Cantidad / maxValue * maxHeight);

                // Dibujar la barra
                g.FillRectangle(brush, x, y - barHeight, barWidth, barHeight);

                // Dibujar el texto (nombre del producto)
                g.DrawString(dato.Producto, font, Brushes.Black, x, y + 5);

                // Actualizar la posición en X para la siguiente barra
                x += barWidth + 20;
            }
        }
    }
}

