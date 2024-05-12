using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using CrimelabHelper.Models;

namespace CrimelabHelper.Repositories
{
    public class EvidenceRepository
    {
        private string connectionString;

        public EvidenceRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public List<Evidence> GetAllEvidences()
        {
            List<Evidence> evidences = new List<Evidence>();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM evidences";
                MySqlCommand command = new MySqlCommand(query, connection);
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Evidence evidence = new Evidence
                        {
                            EvidenceId = reader.GetInt32("evidence_id"),
                            Description = reader.GetString("description"),
                            Type = reader.GetString("type"),
                            Status = reader.GetString("status"),
                            CrimeId = reader.GetInt32("crime_id")
                        };
                        evidences.Add(evidence);
                    }
                }
            }
            return evidences;
        }

        public Evidence GetEvidenceById(int evidenceId)
        {
            Evidence evidence = null;
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM evidences WHERE EvidenceId = @EvidenceId";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@EvidenceId", evidenceId);
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        evidence = new Evidence
                        {
                            EvidenceId = reader.GetInt32("EvidenceId"),
                            Description = reader.GetString("Description"),
                            Type = reader.GetString("Type"),
                            Status = reader.GetString("Status"),
                            CrimeId = reader.GetInt32("CrimeId")
                        };
                    }
                }
            }
            return evidence;
        }

        // Додати методи для вставки, оновлення та видалення даних
    }
}
