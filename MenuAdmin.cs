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
    public partial class MenuAdmin : Form
    {
        public MenuAdmin()
        {
            InitializeComponent();
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

