using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CrimelabHelper
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            // Підключення до бази даних
            string connectionString = "server=localhost;user=root;database=crimelab";
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                MessageBox.Show("Підключено до бази даних!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка підключення до бази даних: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }

            Application.Run(new Form1());
        }
    }
}
