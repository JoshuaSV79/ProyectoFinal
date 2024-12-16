﻿using System;
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
        public login()
        {
            InitializeComponent();
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

            // Crear una instancia de la base de datos
            using (DataBase data = new DataBase())
            {
                // Llamar al método para verificar la cuenta
                Cuentas cuenta = data.VerifyAccount(this.textBoxUser.Text, this.textBoxPassword.Text);

                // Evaluar si la cuenta es válida
                if (cuenta != null)
                {

                    // Obtener el nombre del usuario desde la cuenta
                    string nombreUsuario = cuenta.Name1;
                    MessageBox.Show("Inicio de sesión exitoso", "¡¡Bienvenido!!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Crear y mostrar el formulario de productos
                    pantalla_productos nuevoForm = new pantalla_productos(nombreUsuario);
                

                    nuevoForm.Show();

                    // Cerrar o esconder el formulario actual
                    this.Hide();
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
    }

}
