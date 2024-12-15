using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace ProyectoGina
{
    public class DataBase : IDisposable
    {
        private MySqlConnection Connection;
        private readonly string ConnectionString;

        public DataBase()
        {
            ConnectionString = "Server=127.0.0.1;Database=proyecto_final;User=root;Password=;SslMode=none;";
            Connect();
        }

        public void Connect()
        {
            try
            {
                if (Connection == null)
                    Connection = new MySqlConnection(ConnectionString);

                if (Connection.State != ConnectionState.Open)
                {
                    Connection.Open();
                }
            }
            catch (Exception ex)
            {

            }
        }

        public Cuentas VerifyAccount(string account, string password)
        {
            Cuentas item = null;

            try
            {
                string query = "SELECT * FROM cuentas WHERE Account = @Account AND Password = @Password;";

                using (MySqlCommand command = new MySqlCommand(query, Connection))
                {
                    command.Parameters.AddWithValue("@Account", account);
                    command.Parameters.AddWithValue("@Password", password);

                    if (Connection.State != ConnectionState.Open)
                        Connection.Open();

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            item = new Cuentas
                            {
                                Account1 = reader["Account"].ToString(),
                                Password1 = reader["Password"].ToString()
                            };
                        }
                        else
                        {
                            MessageBox.Show("No existe la cuenta, vuelve a ingresar", "Información", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al leer la tabla de la base de datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Disconnect();
            }

            return item;
        }

        public void Disconnect()
        {
            if (Connection != null && Connection.State == ConnectionState.Open)
            {
                Connection.Close();
            }
        }

        // Implement IDisposable for proper resource management
        public void Dispose()
        {
            Disconnect();
            Connection?.Dispose();
        }
    }
}