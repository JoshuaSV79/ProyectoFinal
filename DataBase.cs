using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Runtime.Intrinsics.Arm;
using Mysqlx.Crud;
using Microsoft.VisualBasic;
using Mysqlx.Connection;
using System.Data;

namespace ProyectoGina
{
    public class DataBase
    {
        private MySqlConnection Connection;
        
       public DataBase()
        {
            this.Connect();
        }

        public void Disconnect()
        {
            if (Connection != null && Connection.State == System.Data.ConnectionState.Open)
            {
                Connection.Close();
                MessageBox.Show("Conexión cerrada correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public Cuentas VerifyAccount(string account, string password)
        {
            Cuentas item = null;

            try
            {
                // Consulta para buscar la cuenta y contraseña
                string query = "SELECT * FROM cuentas WHERE Account = '" + account + "' AND Password = '" + password + "';";

                // Crear el comando
                MySqlCommand command = new MySqlCommand(query, this.Connection);

                // Abrir la conexión si no está abierta
                if (this.Connection.State != ConnectionState.Open)
                    this.Connection.Open();

                // Ejecutar la consulta
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    // Verificar si se encontró un registro
                    if (reader.Read())
                    {
                        // Crear un nuevo objeto Cuentas
                        item = new Cuentas
                        {
                            Account1 = Convert.ToString(reader["Account"].ToString()),
                            Password1 = Convert.ToString(reader["Password"].ToString()),
                        };
                    }
                    else
                    {
                        MessageBox.Show("NO existe la cuenta, vuelve a ingresar");
                    }
                }
            }
            catch (Exception ex)
            {
                // Mostrar mensaje de error
                MessageBox.Show("Error al leer la tabla de la base de datos: " + ex.Message);

                // Desconectar la base de datos
                this.Disconnect();
            }

            // Devolver el item (null si no se encontró)
            return item;
        }


        public void Connect()
        {
            string cadena = "Server=localhost; Database=proyecto_final; User=root; Password=; SslMode=none;";
            try
            {
                Connection = new MySqlConnection(cadena);
                Connection.Open();
                MessageBox.Show("Conexión establecida exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al conectar con la base de datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }


}