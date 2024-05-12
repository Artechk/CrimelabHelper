using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using CrimelabHelper.Models;

namespace CrimelabHelper.Data
{
    public class SuspectRepository
    {
        private string connectionString;

        public SuspectRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public List<Suspect> GetAllSuspects()
        {
            List<Suspect> suspects = new List<Suspect>();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM suspects";
                MySqlCommand command = new MySqlCommand(query, connection);
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Suspect suspect = new Suspect
                        {
                            SuspectId = reader.GetInt32("SuspectId"),
                            Name = reader.GetString("Name"),
                            Dob = reader.GetDateTime("Dob"),
                            Address = reader.GetString("Address"),
                            Status = reader.GetString("Status"),
                            CrimeId = reader.GetInt32("CrimeId")
                        };
                        suspects.Add(suspect);
                    }
                }
            }
            return suspects;
        }

        public Suspect GetSuspectById(int suspectId)
        {
            Suspect suspect = null;
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM suspects WHERE SuspectId = @SuspectId";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@SuspectId", suspectId);
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        suspect = new Suspect
                        {
                            SuspectId = reader.GetInt32("SuspectId"),
                            Name = reader.GetString("Name"),
                            Dob = reader.GetDateTime("Dob"),
                            Address = reader.GetString("Address"),
                            Status = reader.GetString("Status"),
                            CrimeId = reader.GetInt32("CrimeId")
                        };
                    }
                }
            }
            return suspect;
        }

        // Додати методи для вставки, оновлення та видалення даних
    }
}
