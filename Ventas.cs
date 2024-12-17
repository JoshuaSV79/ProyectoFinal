using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoGina
{
    public partial class Ventas : Form
    {

        private ListaEnlazadaVentas listaVentas;
        public Ventas()
        {
            InitializeComponent();
            listaVentas = new ListaEnlazadaVentas();
            CargarVentas();
        }

        private void CargarVentas()
        {
            listaVentas.AgregarVenta(100.50);
            listaVentas.AgregarVenta(200.75);
            listaVentas.AgregarVenta(50.25);
            listaVentas.AgregarVenta(300.00);
        }


        private void Ventas_Load(object sender, EventArgs e)
        {
            // Mostrar montos individuales en un ListBox
            List<double> montos = listaVentas.ObtenerMontos();
            foreach (double monto in montos)
            {
                listBoxVentas.Items.Add($"Monto: ${monto:F2}");
            }

            // Mostrar resumen de ventas en un Label
            int numeroVentas = listaVentas.ContarVentas();
            double totalVentas = listaVentas.CalcularTotalVentas();
            lblResumenVentas.Text = $"Número de Ventas: {numeroVentas}\nTotal Ventas: ${totalVentas:F2}";
        }

        private void listBoxVentas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
