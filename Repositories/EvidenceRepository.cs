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
                string query = "SELECT * FROM evidences WHERE evidence_id = @EvidenceId";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@EvidenceId", evidenceId);
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        evidence = new Evidence
                        {
                            EvidenceId = reader.GetInt32("evidence_id"),
                            Description = reader.GetString("description"),
                            Type = reader.GetString("type"),
                            Status = reader.GetString("status"),
                            CrimeId = reader.GetInt32("crime_id")
                        };
                    }
                }
            }
            return evidence;
        }

        public void AddEvidence(Evidence evidence)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO evidences (description, type, status, crime_id) VALUES (@Description, @Type, @Status, @CrimeId)";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Description", evidence.Description);
                command.Parameters.AddWithValue("@Type", evidence.Type);
                command.Parameters.AddWithValue("@Status", evidence.Status);
                command.Parameters.AddWithValue("@CrimeId", evidence.CrimeId);
                command.ExecuteNonQuery();
            }
        }

        public void UpdateEvidence(Evidence evidence)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE evidences SET description = @Description, type = @Type, status = @Status, crime_id = @CrimeId WHERE evidence_id = @EvidenceId";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Description", evidence.Description);
                command.Parameters.AddWithValue("@Type", evidence.Type);
                command.Parameters.AddWithValue("@Status", evidence.Status);
                command.Parameters.AddWithValue("@CrimeId", evidence.CrimeId);
                command.Parameters.AddWithValue("@EvidenceId", evidence.EvidenceId);
                command.ExecuteNonQuery();
            }
        }

        public void DeleteEvidence(int evidenceId)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "DELETE FROM evidences WHERE evidence_id = @EvidenceId";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@EvidenceId", evidenceId);
                command.ExecuteNonQuery();
            }
        }
    }
}
