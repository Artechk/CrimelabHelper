using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using CrimelabHelper.Models;

namespace CrimelabHelper.Repositories
{
    public class CrimeRepository
    {
        private string connectionString;

        public CrimeRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public List<Crime> GetAllCrimes()
        {
            List<Crime> crimes = new List<Crime>();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM crimes";
                MySqlCommand command = new MySqlCommand(query, connection);
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Crime crime = new Crime
                        {
                            CrimeId = reader.GetInt32("CrimeId"),
                            Description = reader.GetString("Description"),
                            Date = reader.GetDateTime("Date"),
                            Location = reader.GetString("Location"),
                            Type = reader.GetString("Type")
                        };
                        crimes.Add(crime);
                    }
                }
            }
            return crimes;
        }

        // Додати методи для вставки, оновлення та видалення даних
    }
}
