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
    public partial class productoscs : Form
    {

        private string connectionString = "Server=127.0.0.1;Database=proyecto_final;User=root;Password=;SslMode=none;";

        public productoscs()
        {
            InitializeComponent();
            this.Load += new EventHandler(Productos_Load);
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            // Cargar los datos en el DataGridView cuando se abra el formulario
            CargarDatosEnDataGridView();
        }

        private void CargarDatosEnDataGridView()
        {
            try
            {
                // Consulta SQL para seleccionar los datos de la tabla
                string query = "SELECT * FROM productos";

                // Crear la conexión con la base de datos
                using (MySqlConnection conexion = new MySqlConnection(connectionString))
                {
                    // Crear un adaptador de datos
                    MySqlDataAdapter adaptador = new MySqlDataAdapter(query, conexion);

                    // Crear un DataTable para almacenar los datos
                    DataTable dataTable = new DataTable();

                    // Llenar el DataTable con los datos del adaptador
                    adaptador.Fill(dataTable);

                    // Asignar el DataTable como fuente de datos del DataGridView
                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                // Mostrar cualquier error
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
