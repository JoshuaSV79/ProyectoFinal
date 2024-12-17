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
    public partial class previa_productos : Form
    {

        // Crear el objeto ToolTip
        ToolTip toolTip1 = new ToolTip();
        public previa_productos()
        {
            InitializeComponent();
            //tooltips
            toolTip1.SetToolTip(label4, "Nombre del sistema");
            toolTip1.SetToolTip(label1, "Slogan de FutureByte");
            toolTip1.SetToolTip(pictureBox1, "Logotipo de FutureByte");
            toolTip1.SetToolTip(button_atras, "Volver a atras");
            toolTip1.SetToolTip(image, "Imagen del producto");
            toolTip1.SetToolTip(name, "Nombre del producto");
            toolTip1.SetToolTip(price, "Precio del producto");
            toolTip1.SetToolTip(descripcion, "Descripcion del producto");
            toolTip1.SetToolTip(id, "Id del producto");
            toolTip1.SetToolTip(existencias, "Cantidad disponible");
            toolTip1.SetToolTip(button3, "Presiona para enviar");
            toolTip1.SetToolTip(label2, "Pantalla de informacion de producto");

        }

        private void button_atras_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void previa_productos_Load(object sender, EventArgs e)
        {

        }
    }
}
