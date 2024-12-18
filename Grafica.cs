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
    public partial class Grafica : Form
    {
        public Grafica()
        {
            InitializeComponent();
        }

        private void Grafica_Load(object sender, EventArgs e)
        {
            //grafica dinamica
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button_atras_Click(object sender, EventArgs e)
        {
            MenuAdmin menu = new MenuAdmin();
            menu.Show();
            this.Close();
        }
    }
}
