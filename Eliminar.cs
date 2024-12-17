using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Org.BouncyCastle.Pqc.Crypto.Lms;

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
                Products aux = data.CheckAProduct(Convert.ToInt32(this.textBoxId.Text));
                DataTable productos = new DataTable();
                PictureBox img = this.Controls.Find("pictureBoxproducto", true).FirstOrDefault() as PictureBox;

                this.textBoxName.Text = aux.Nombre;
                this.textBoxPrice.Text = Convert.ToString(aux.Precio);
                this.textBoxDes.Text = aux.Descripcion;
                this.textBoxExis.Text = Convert.ToString(aux.Existencias);
                this.textBoxPicture.Text = aux.Imagen;

                // Cargar imagen
                if (img != null)
                {
                    // Usar la ruta de imagen del producto
                    string fullPath = System.IO.Path.Combine(Application.StartupPath, "Resources", aux.Imagen);

                    if (System.IO.File.Exists(fullPath))
                    {
                        try
                        {
                            // Cargar la imagen
                            img.Image = Image.FromFile(fullPath);
                            img.SizeMode = PictureBoxSizeMode.Zoom;
                        }
                        catch (Exception ex)
                        {
                            // Manejo de errores si la imagen no se puede cargar
                            MessageBox.Show($"Error al cargar la imagen: {ex.Message}");
                        }
                    }
                    else
                    {
                        // Limpiar la imagen si no se encuentra el archivo
                        img.Image = null;
                        MessageBox.Show("Archivo de imagen no encontrado.");
                    }
                }
                else
                {
                    MessageBox.Show("PictureBox no encontrado.");
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            using (DataBase data = new DataBase())
            {
                data.Delete(Convert.ToInt32(this.textBoxId));
            }
        }

        private void button_atras_Click(object sender, EventArgs e)
        {
            MenuAdmin menu = new MenuAdmin();
            menu.Show();
            this.Hide();

        }
    }
}
