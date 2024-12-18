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
                    string query = "SELECT id, nombre, precio, descripcion, existencias, image_id FROM productos LIMIT 10;";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable productos = new DataTable();
                            adapter.Fill(productos);

                            for (int i = 0; i < productos.Rows.Count; i++)
                            {
                                // Buscar controles
                                Panel panel = this.Controls.Find($"producto0{i + 1}", true)[0] as Panel;
                                PictureBox img = this.Controls.Find($"img_prod0{i + 1}", true)[0] as PictureBox;
                                Label lblNombre = this.Controls.Find($"prod_name0{i + 1}", true)[0] as Label;
                                Label lblPrecio = this.Controls.Find($"price_prod0{i + 1}", true)[0] as Label;

                                // Asignar valores
                                lblNombre.Text = productos.Rows[i]["nombre"].ToString();
                                lblPrecio.Text = $"${productos.Rows[i]["precio"]}";

                                // Cargar imagen
                                string imageName = productos.Rows[i]["image_id"].ToString();
                                string fullPath = System.IO.Path.Combine(Application.StartupPath, "Resources", imageName);
                                if (System.IO.File.Exists(fullPath))
                                {
                                    img.Image = Image.FromFile(fullPath);
                                    img.SizeMode = PictureBoxSizeMode.Zoom;
                                }

                                // Evento Click para abrir el formulario con los datos
                                string id = productos.Rows[i]["id"].ToString();
                                string nombre = productos.Rows[i]["nombre"].ToString();
                                string precio = productos.Rows[i]["precio"].ToString();
                                string descripcion = productos.Rows[i]["descripcion"].ToString();
                                string existencias = productos.Rows[i]["existencias"].ToString();

                                panel.Click += (sender, e) =>
                                {
                                    AbrirPreviaProducto(id, nombre, precio, descripcion, imageName, existencias);
                                };

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

        private pedido formularioPedido;

        private void AbrirPreviaProducto(string id, string nombre, string precio, string descripcion, string imageName, string existencias)
        {
            // Verificar si formularioPedido existe
            if (formularioPedido == null || formularioPedido.IsDisposed)
            {
                formularioPedido = new pedido(this); // Crear una nueva instancia
            }

            // Crear la instancia de previa_productos pasando formularioPedido
            previa_productos detalleForm = new previa_productos(formularioPedido);

            // Configurar el formulario con la información del producto
            detalleForm.ProductoNombre = nombre;
            detalleForm.ProductoPrecio = double.Parse(precio);
            detalleForm.InicializarExistencias(int.Parse(existencias));

            // Asignar controles
            detalleForm.name.Text = nombre;
            detalleForm.price.Text = $"Precio: ${precio}";
            detalleForm.descripcion.Text = descripcion;
            detalleForm.id.Text = $"ID: {id}";
            detalleForm.label_existencias.Text = $"{existencias}";

            // Cargar imagen
            string fullPath = System.IO.Path.Combine(Application.StartupPath, "Resources", imageName);
            if (System.IO.File.Exists(fullPath))
            {
                detalleForm.image.Image = Image.FromFile(fullPath);
                detalleForm.image.SizeMode = PictureBoxSizeMode.Zoom;
            }

            // Mostrar previa_productos
            detalleForm.ShowDialog();
        }


        private void pantalla_productos_Load(object sender, EventArgs e)
        {

        }
        private void button_pedido_Click(object sender, EventArgs e)
        {
            if (formularioPedido == null || formularioPedido.IsDisposed)
            {
                formularioPedido = new pedido(this); // Pasa la instancia actual de pantalla_productos
            }
            formularioPedido.Show();
            formularioPedido.BringToFront();
            
        }
    }
}
