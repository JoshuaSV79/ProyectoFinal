using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProyectoGina
{
    public partial class pantalla_productos : Form
    {
        private string connectionString = "Server=127.0.0.1;Database=proyecto_final;User=root;Password=;SslMode=none;";
        public pantalla_productos(string nombreUsuario)
        {
            InitializeComponent();
            label_usuario.Text = nombreUsuario;
            CargarProductos(); // Llama a la función para llenar los paneles
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
        }

        private void log_out_Click(object sender, EventArgs e)
        {
            login logOut = new login();
            logOut.Show();
            this.Hide();
        }

        private void button_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Cargar los productos desde la base de datos y asignarlos a los paneles
        private void CargarProductos()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT nombre, precio, image_id FROM productos LIMIT 10;";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable productos = new DataTable();
                            adapter.Fill(productos);

                            for (int i = 0; i < productos.Rows.Count; i++)
                            {
                                Panel panel = this.Controls.Find($"producto0{i + 1}", true)[0] as Panel;
                                PictureBox img = this.Controls.Find($"img_prod0{i + 1}", true)[0] as PictureBox;
                                Label lblNombre = this.Controls.Find($"prod_name0{i + 1}", true)[0] as Label;
                                Label lblPrecio = this.Controls.Find($"price_prod0{i + 1}", true)[0] as Label;

                                lblNombre.Text = productos.Rows[i]["nombre"].ToString();
                                lblPrecio.Text = $"${productos.Rows[i]["precio"]}";

                                // Obtener la ruta absoluta de la imagen
                                string imageName = productos.Rows[i]["image_id"].ToString();
                                string fullPath = System.IO.Path.Combine(Application.StartupPath, "Resources", imageName);

                                if (System.IO.File.Exists(fullPath))
                                {
                                    img.Image = Image.FromFile(fullPath);
                                    img.SizeMode = PictureBoxSizeMode.Zoom;
                                }
                                else
                                {
                                    img.Image = Properties.Resources.logo_fuby; // Imagen por defect
                                }

                                panel.Visible = true;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }


        private void pantalla_productos_Load(object sender, EventArgs e)
        {

        }
    }
}
