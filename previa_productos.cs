using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProyectoGina
{
    public partial class previa_productos : Form
    {
        private int existenciasDisponibles = 0; // Existencias actuales
        private int cantidadSeleccionada = 0;   // Cantidad seleccionada
        public string ProductoNombre { get; set; } // Nombre del producto
        public double ProductoPrecio { get; set; } // Precio del producto

        // Instancia global de "pedido" para reutilizar
        private pedido formularioPedido;

        public previa_productos(pedido pedidoForm)
        {
            InitializeComponent();
            formularioPedido = pedidoForm; // Guarda la referencia a pedido
        }

        private void button_atras_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        // Método para inicializar existencias
        public void InicializarExistencias(int existencias)
        {
            existenciasDisponibles = existencias;
            textBox_cant.Text = "0";
            cantidadSeleccionada = 0;
            label_existencias.Text = existencias.ToString(); // Mostrar existencias

            // Actualizar el estado del label_agotado
            if (existenciasDisponibles == 0)
            {
                label_agotado.Text = "Producto agotado";
            }
            else
            {
                label_agotado.Text = string.Empty; // Limpiar el texto si hay existencias
            }
        }


        // Botón "Más"
        private void button_mas_Click(object sender, EventArgs e)
        {
            if (cantidadSeleccionada < existenciasDisponibles)
            {
                cantidadSeleccionada++;
                textBox_cant.Text = cantidadSeleccionada.ToString();
            }
            else
            {
                MessageBox.Show("¡Límite de existencias alcanzado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Botón "Menos"
        private void button_menos_Click(object sender, EventArgs e)
        {
            if (cantidadSeleccionada > 0)
            {
                cantidadSeleccionada--;
                textBox_cant.Text = cantidadSeleccionada.ToString();
            }
        }

        // Botón "Enviar"
        private void button_enviar_Click(object sender, EventArgs e)
        {
            if (cantidadSeleccionada == 0)
            {
                MessageBox.Show("Debe seleccionar al menos un producto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                // Actualizar existencias y ventas en la base de datos
                using (MySqlConnection connection = new MySqlConnection("Server=127.0.0.1;Database=proyecto_final;User=root;Password=;SslMode=none;"))
                {
                    connection.Open();
                    string query = "UPDATE productos SET existencias = existencias - @cantidad, ventas = ventas + @cantidad WHERE nombre = @nombre";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@cantidad", cantidadSeleccionada);
                        cmd.Parameters.AddWithValue("@nombre", ProductoNombre);

                        int filasAfectadas = cmd.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            // Actualizar existencias locales
                            existenciasDisponibles -= cantidadSeleccionada;
                            label_existencias.Text = existenciasDisponibles.ToString();

                            // Agregar al formulario "pedido"
                            string detallePedido = $"Producto: {ProductoNombre} | Cantidad: {cantidadSeleccionada} | Precio Total: ${ProductoPrecio * cantidadSeleccionada}";
                            formularioPedido.AgregarPedido(detallePedido, ProductoPrecio * cantidadSeleccionada);

                            MessageBox.Show("Pedido enviado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Reiniciar valores
                            cantidadSeleccionada = 0;
                            textBox_cant.Text = "0";
                        }
                        else
                        {
                            MessageBox.Show("Error: El producto no se encontró o no se actualizaron existencias.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar la base de datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }
        }
    }
