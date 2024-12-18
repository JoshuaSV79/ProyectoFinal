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
    public partial class pedido : Form
    {

        public pedido()
        {
            InitializeComponent();
        }
        private double totalPedido = 0;

        // Método para agregar un pedido al RichTextBox
        public void AgregarPedido(string detallePedido, double subtotal)
        {
            if (pedido_richtxt != null)
            {
                pedido_richtxt.AppendText(detallePedido + Environment.NewLine);
                totalPedido += subtotal; // Suma el subtotal al total acumulado
                total.Text = $"${totalPedido:F2}"; // Actualiza la etiqueta total
            }
            else
            {
                MessageBox.Show("Error al mostrar el pedido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private pantalla_productos pantallaProductos;

        public pedido(pantalla_productos pantalla)
        {
            InitializeComponent();
            pantallaProductos = pantalla;
        }
        private void button_atras_Click(object sender, EventArgs e)
        {
            if (pantallaProductos != null)
            {
                this.Hide();
                pantallaProductos.Show();
            }
            else
            {
                MessageBox.Show("Error: La referencia a pantalla_productos no se inicializó.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            if (pantallaProductos != null)
            {
                FormPagos formPagos = new FormPagos(totalPedido, pantallaProductos);
                this.Hide();
                formPagos.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Error: No se pudo regresar a la pantalla de productos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}

    
