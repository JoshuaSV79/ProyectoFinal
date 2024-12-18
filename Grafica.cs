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
using System.Windows.Forms.DataVisualization.Charting;

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
            CargarDatosVentas();

        }
        private void CargarDatosVentas()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection("Server=127.0.0.1;Database=proyecto_final;User=root;Password=;SslMode=none;"))
                {
                    connection.Open();
                    string query = "SELECT nombre, ventas, precio FROM productos WHERE ventas > 0";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        // Limpiar series previas del gráfico
                        chart1.Series.Clear();
                        chart1.Titles.Clear();

                        // Crear una nueva serie para el gráfico de pastel
                        Series series = new Series("Ventas");
                        series.ChartType = SeriesChartType.Pie;

                        // Lista para almacenar datos de ventas
                        List<(string nombre, int ventas, double ingresos)> datosVentas = new List<(string, int, double)>();

                        // Leer los datos y almacenarlos
                        while (reader.Read())
                        {
                            string nombre = reader.GetString("nombre");
                            int ventas = reader.GetInt32("ventas");
                            double precio = reader.GetDouble("precio");
                            double ingresos = ventas * precio;

                            datosVentas.Add((nombre, ventas, ingresos));
                        }

                        // Ordenar los datos por ingresos en orden descendente
                        var datosOrdenados = datosVentas.OrderByDescending(x => x.ingresos).ToList();

                        // Agregar puntos al gráfico de pastel
                        foreach (var dato in datosOrdenados)
                        {
                            series.Points.AddXY(
                                $"{dato.nombre}\n({dato.ventas} unidades)\n{dato.ingresos:C2}",
                                dato.ingresos
                            );
                        }

                        // Configurar propiedades del gráfico
                        chart1.Series.Add(series);

                        // Agregar título
                        chart1.Titles.Add(new Title("Distribución de Ventas por Producto", Docking.Top));

                        // Configurar leyenda
                        chart1.Legends.Clear();
                        Legend legend = new Legend("Productos");
                        legend.Docking = Docking.Right;
                        chart1.Legends.Add(legend);

                        // Configuraciones adicionales de estilo
                        series["PieLabelStyle"] = "Outside";
                        series.Label = "#PERCENT{P2}";
                        series.LegendText = "#VALX";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos de ventas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
