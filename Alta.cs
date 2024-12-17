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
            // no se si esto tambien sirva pero sirve para agregarla en ejcucion 
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Configurar el filtro para que solo permita imágenes
            openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            openFileDialog.Title = "Seleccione una imagen";

            // Mostrar el cuadro de diálogo
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Cargar la imagen seleccionada en el PictureBox
                pictureBox2.Image = Image.FromFile(openFileDialog.FileName);

                // Ajustar el tamaño de la imagen en el PictureBox
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
    }

