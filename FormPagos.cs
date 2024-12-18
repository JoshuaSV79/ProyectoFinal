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
    public partial class FormPagos : Form
    {
        private pantalla_productos pantallaProductos;
        public FormPagos(double total, pantalla_productos pantalla)
        {
            InitializeComponent();
            total_pagar.Text = $"{total:F2}"; // Actualiza el label con el total
            pantallaProductos = pantalla;
        }

        private void FormPagos_Load(object sender, EventArgs e)
        {

        }

        private void buttonPagoEfectivo_Click(object sender, EventArgs e)
        {
            double total = double.Parse(total_pagar.Text);
            PagoEfectivoForm efectivoForm = new PagoEfectivoForm(total, pantallaProductos);
            this.Hide();
            efectivoForm.ShowDialog();
            this.Close();
        }

        private void buttonPagoOxxo_Click(object sender, EventArgs e)
        {
            double total = double.Parse(total_pagar.Text);
            PagoOxxoForm oxxoForm = new PagoOxxoForm(total, pantallaProductos);
            this.Hide();
            oxxoForm.ShowDialog();
            this.Close();
        }

        private void buttonPagoTarjeta_Click(object sender, EventArgs e)
        {
            double total = double.Parse(total_pagar.Text);
            PagoTarjetaForm tarjetaForm = new PagoTarjetaForm(total, pantallaProductos);
            this.Hide();
            tarjetaForm.ShowDialog();
            this.Close();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            pedido pantallaPedido = new pedido();
            this.Hide();
            pantallaPedido.Show();
        }

    }
}
