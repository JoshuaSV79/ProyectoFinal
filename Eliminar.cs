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
    public partial class Eliminar : Form
    {
        public Eliminar()
        {
            InitializeComponent();
        }

        private void buttonConsultar_Click(object sender, EventArgs e)
        {
            using (DataBase data = new DataBase())
            {
                Products aux = data.CheckAProduct(Convert.ToInt32(this.textBoxId));

                this.textBoxName.Text = aux.Nombre;
                this.textBoxPrice.Text = Convert.ToString(aux.Precio);
                this.textBoxDes.Text = aux.Descripcion;
                this.textBoxExis.Text = Convert.ToString(aux.Existencias);
                this.textBoxPicture.Text = aux.Imagen;

            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            using (DataBase data = new DataBase())
            {
                data.Delete(Convert.ToInt32(this.textBoxId));
            }
        }
    }
}
