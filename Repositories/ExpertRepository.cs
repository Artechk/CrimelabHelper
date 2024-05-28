using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using CrimelabHelper.Models;
using Mysqlx.Expr;

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
                string query = "SELECT * FROM experts WHERE expert_id = @ExpertId";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@ExpertId", expertId);
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        expert = new Expert
                        {
                            ExpertId = reader.GetInt32("expert_id"),
                            Name = reader.GetString("name"),
                            Specialization = reader.GetString("specialization"),
                            Contact = reader.GetString("contact_info")
                        };
                    }
                }
            }
            return expert;
        }

        public void AddExpert(Expert expert)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO experts (contact_info, specialization, name) VALUES (@Contact, @Specialization, @Name)";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", expert.Name);
                command.Parameters.AddWithValue("@Specialization", expert.Specialization);
                command.Parameters.AddWithValue("@Contact", expert.Contact);
                command.ExecuteNonQuery();
            }
        }

        public void UpdateExpert(Expert expert)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE experts SET name = @Name, specialization = @Specialization, contact_info = @Contact WHERE expert_id = @ExpertId";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", expert.Name);
                command.Parameters.AddWithValue("@Specialization", expert.Specialization);
                command.Parameters.AddWithValue("@Contact", expert.Contact);
                command.Parameters.AddWithValue("@ExpertId", expert.ExpertId);
                command.ExecuteNonQuery();
            }
        }

        public void DeleteExpert(int expertId)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "DELETE FROM experts WHERE expert_id = @ExpertId";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@ExpertId", expertId);
                command.ExecuteNonQuery();
            }
        }

        public List<(string ExpertName, int TotalReports)> GetReportCountsByExpert()
        {
            List<(string ExpertName, int TotalReports)> result = new List<(string ExpertName, int TotalReports)>();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT experts.name, COUNT(*) AS TotalReports FROM experts INNER JOIN investigation_reports ON experts.expert_id = investigation_reports.expert GROUP BY experts.name";
                MySqlCommand command = new MySqlCommand(query, connection);
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        result.Add((reader.GetString("name"), reader.GetInt32("TotalReports")));
                    }
                }
            }
            return result;
        }

    }
}
