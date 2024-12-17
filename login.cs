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
    public partial class login : Form
    {

        // Crear el objeto ToolTip
        ToolTip toolTip1 = new ToolTip();
        public login()
        {
            InitializeComponent();

            //tooltips
            toolTip1.SetToolTip(label4, "Nombre del sistema");
            toolTip1.SetToolTip(label1, "Slogan de FutureByte");
            toolTip1.SetToolTip(pictureBox1, "Logotipo de FutureByte");
            toolTip1.SetToolTip(button_salir, "Salir del sistema");
            toolTip1.SetToolTip(button_atras, "Volver a atras");

            toolTip1.SetToolTip(textBoxUser, "Ingresar usuario");
            toolTip1.SetToolTip(textBoxPassword, "Ingresar contraseña");
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            // Verificar si los campos están vacíos
            if (string.IsNullOrWhiteSpace(textBoxUser.Text) || string.IsNullOrWhiteSpace(textBoxPassword.Text))
            {
                MessageBox.Show("Por favor, ingrese usuario y contraseña.",
                    "Campos Vacíos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            using (DataBase data = new DataBase())
            {
                // Llamar al método para verificar la cuenta
                Cuentas cuenta = data.VerifyAccount(this.textBoxUser.Text, this.textBoxPassword.Text);
                // Evaluar si la cuenta es válida
                if (cuenta != null)
                {

                    // Obtener el nombre del usuario desde la cuenta
                    string nombreUsuario = cuenta.Name1;
                    bool esAdmin = cuenta.Account1 == "Admin@admin.com";

                    if (esAdmin)
                    {
                        // Mostrar el formulario de administrador
                        MenuAdmin menuadmin = new MenuAdmin();
                        menuadmin.Show();
                        this.Hide();
                        MessageBox.Show("Inicio de sesión exitoso", "¡¡Bienvenido!!",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        // Mostrar el formulario de productos
                        pantalla_productos nuevoForm = new pantalla_productos(nombreUsuario);
                        nuevoForm.Show();
                        MessageBox.Show("Inicio de sesión exitoso", "¡¡Bienvenido!!",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Error, usuario o contraseña incorrectos.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

            

        private void button_atras_Click(object sender, EventArgs e)
        {
            // Mostrar Form1
            Form1 form1 = new Form1();
            form1.Show();

            // Ocultar el formulario actual
            this.Hide();
        }

        private void button_salir_Click(object sender, EventArgs e)
        {
            // salir
            Application.Exit();
        }

        private void textBoxUser_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
