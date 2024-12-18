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
    public partial class PagoTarjetaForm : Form
    {

        private pantalla_productos pantallaProductos;
        public PagoTarjetaForm(double total, pantalla_productos pantalla)
        {
            InitializeComponent();
            total_pagar.Text = $"{total:F2}";
            pantallaProductos = pantalla;
        }

        private void buttonConfirmarPago_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¡Compra exitosa!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
            pantallaProductos.Show();
        }
    }
}
