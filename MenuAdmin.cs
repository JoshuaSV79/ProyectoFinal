using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Interop;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoGina
{
    public partial class MenuAdmin : Form
    {
        // Crear el objeto ToolTip
        ToolTip toolTip1 = new ToolTip();

        public MenuAdmin()
        {
            InitializeComponent();
            //tooltips
            toolTip1.SetToolTip(buttonLogin, "Alta de producto");
            toolTip1.SetToolTip(button7, "Eliminar producto");
            toolTip1.SetToolTip(button3, "listas de productos");
            toolTip1.SetToolTip(button4, "Lista de ventas");
            toolTip1.SetToolTip(button5, "Mostrar grafica");
            toolTip1.SetToolTip(button6, "Cerrar sesion");

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Alta f = new Alta();
            f.Show();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Eliminar f4 = new Eliminar();
            f4.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Productos f4 = new Productos();
            f4.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Ventas f4 = new Ventas();
            f4.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Grafica f4 = new Grafica();
            f4.Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            login logOut = new login();
            logOut.Show();
            this.Close();
        }
    }
}

