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
        private DataBase dataBase;

        public productoscs()
        {
            InitializeComponent();
            this.Load += new EventHandler(Productos_Load);
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            // Crear una instancia de la clase DataBase
            dataBase = new DataBase();

            // Cargar los datos en el DataGridView cuando se abra el formulario
            CargarDatosEnDataGridView();
        }

        private void CargarDatosEnDataGridView()
        {
            try
            {
                // Obtener los productos desde la base de datos
                DataTable productosTable = dataBase.ObtenerProductos();

                // Asignar el DataTable como fuente de datos del DataGridView
                dataGridView1.DataSource = productosTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los productos: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Manejo de clic en la celda si es necesario
        }

        private void productoscs_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
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