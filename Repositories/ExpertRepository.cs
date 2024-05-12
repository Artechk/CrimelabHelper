using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using CrimelabHelper.Models;

namespace CrimelabHelper.Repositories
{
    public class ExpertRepository
    {
        private string connectionString;

        public ExpertRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public List<Expert> GetAllExperts()
        {
            List<Expert> experts = new List<Expert>();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM experts";
                MySqlCommand command = new MySqlCommand(query, connection);
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Expert expert = new Expert
                        {
                            ExpertId = reader.GetInt32("expert_id"),
                            Name = reader.GetString("name"),
                            Specialization = reader.GetString("specialization"),
                            Contact = reader.GetString("contact_info")
                        };
                        experts.Add(expert);
                    }
                }
            }
            return experts;
        }

        public Expert GetExpertById(int expertId)
        {
            Expert expert = null;
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM experts WHERE ExpertId = @ExpertId";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@ExpertId", expertId);
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        expert = new Expert
                        {
                            ExpertId = reader.GetInt32("ExpertId"),
                            Name = reader.GetString("Name"),
                            Specialization = reader.GetString("Specialization")
                        };
                    }
                }
            }
            return expert;
        }

        // Додати методи для вставки, оновлення та видалення даних
    }
}
