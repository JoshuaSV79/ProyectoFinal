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
    public partial class PagoOxxoForm : Form
    {
        private pantalla_productos pantallaProductos;
        public PagoOxxoForm(double total, pantalla_productos pantalla)
        {
            InitializeComponent();
            total_pagar.Text = $"{total:F2}";
            pantallaProductos = pantalla;
        }

        private void buttonConfirmarPago_Click(object sender, EventArgs e)
        {
            try
            {
                // Lógica de confirmación (como actualizar existencias ya realizada)
                MessageBox.Show("¡Compra exitosa!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Registro en el formulario Ventas
                // Puedes usar una referencia global o cargar los datos desde la base de datos

                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al confirmar el pago: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
