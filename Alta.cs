using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ProyectoGina
{
    public partial class Alta : Form
    {
        public Alta()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id;
            string nombre;
            string imagen;
            int precio;
            int existencias;
            string descripcion;
            id = Convert.ToInt32(this.textBoxId.Text);
            nombre = this.textBoxNombre.Text;
            imagen = this.textBoxImagen.Text;
            precio = Convert.ToInt32(this.textBoxPrecio.Text);
            existencias = Convert.ToInt32(this.textBoxExistencias.Text);
            descripcion = this.textBoxDescripcion.Text; 

            DataBase obj = new DataBase();
            obj.insertar(id, nombre, descripcion, precio, existencias, imagen);
            obj.Disconnect();
        }

        private void textBoxPrecio_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
    

