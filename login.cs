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
        public login()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
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
                Cuentas cuenta = new Cuentas();

                data.VerifyAccount(this.textBoxUser.Text,this.textBoxPassword.Text);

                if (cuenta != null)
                {
                    MessageBox.Show("Inicio de sesion exitoso","¡¡Bienvenido!!",MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }
    }
}
