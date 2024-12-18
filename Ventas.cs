using MySql.Data.MySqlClient;
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
    public partial class Ventas : Form
    {

        public Ventas()
        {
            InitializeComponent();
        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            //mostrar donde se almacena el total de ventas de la tienda hasta el momento ya sea tabla o archivo
            CargarVentas();
        }

        private void button_atras_Click(object sender, EventArgs e)
        {
            MenuAdmin menu = new MenuAdmin();
            menu.Show();
            this.Close();
        }
        public void CargarVentas()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection("Server=127.0.0.1;Database=proyecto_final;User=root;Password=;SslMode=none;"))
                {
                    connection.Open();
                    string query = "SELECT nombre, precio, ventas FROM productos WHERE ventas > 0";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        box_ventas.Clear();
                        double totalVendido = 0; // Variable para el total vendido

                        while (reader.Read())
                        {
                            string nombre = reader.GetString("nombre");
                            double precio = reader.GetDouble("precio");
                            int piezasVendidas = reader.GetInt32("ventas");
                            double totalGenerado = precio * piezasVendidas;

                            totalVendido += totalGenerado; // Sumar al total vendido

                            box_ventas.AppendText($"Producto: {nombre}, Precio: {precio:C2}, Piezas: {piezasVendidas}, Total: {totalGenerado:C2}\n");
                        }

                        // Mostrar el total vendido en el Label
                        total_text.Text = $"{totalVendido:C2}";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las ventas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void total_text_Click(object sender, EventArgs e)
        {

        }
    }
}
