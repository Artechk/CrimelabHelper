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
            // ϳ��������� �� ���� �����
            string connectionString = "server=localhost;user=root;database=crimelab";
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                MessageBox.Show("ϳ�������� �� ���� �����!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"������� ���������� �� ���� �����: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }

            Application.Run(new Form1());
        }
    }
}
