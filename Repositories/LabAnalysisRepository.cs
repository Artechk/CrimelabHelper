using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using CrimelabHelper.Models;

namespace CrimelabHelper.Repositories
{
    public class LabAnalysisRepository
    {
        private string connectionString;

        public LabAnalysisRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public List<LabAnalysis> GetAllLabAnalyses()
        {
            List<LabAnalysis> analyses = new List<LabAnalysis>();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM lab_analyses";
                MySqlCommand command = new MySqlCommand(query, connection);
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        LabAnalysis analysis = new LabAnalysis
                        {
                            AnalysisId = reader.GetInt32("analysis_id"),
                            EvidenceId = reader.GetInt32("evidence_id"),
                            Date = reader.GetDateTime("date"),
                            Results = reader.GetString("results"),
                        };
                        analyses.Add(analysis);
                    }
                }
            }
            return analyses;
        }

        public LabAnalysis GetLabAnalysisById(int analysisId)
        {
            LabAnalysis analysis = null;
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM lab_analyses WHERE analysis_id = @AnalysisId";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@AnalysisId", analysisId);
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        analysis = new LabAnalysis
                        {
                            AnalysisId = reader.GetInt32("analysis_id"),
                            EvidenceId = reader.GetInt32("evidence_id"),
                            Date = reader.GetDateTime("date"),
                            Results = reader.GetString("results"),
                        };
                    }
                }
            }
            return analysis;
        }

        public void AddAnalysis(LabAnalysis labAnalysis)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO lab_analyses (evidence_id, date, results) VALUES (@EvidenceId, @Date, @Results)";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@EvidenceId", labAnalysis.EvidenceId);
                command.Parameters.AddWithValue("@Date", labAnalysis.Date);
                command.Parameters.AddWithValue("@Results", labAnalysis.Results);
                command.ExecuteNonQuery();
            }
        }

        public void UpdateAnalysis(LabAnalysis labAnalysis)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE lab_analyses SET evidence_id = @EvidenceId, date = @Date, results = @Results WHERE analysis_id = @AnalysisId";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@EvidenceId", labAnalysis.EvidenceId);
                command.Parameters.AddWithValue("@Date", labAnalysis.Date);
                command.Parameters.AddWithValue("@Results", labAnalysis.Results);
                command.Parameters.AddWithValue("@AnalysisId", labAnalysis.AnalysisId);
                command.ExecuteNonQuery();
            }
        }

        public void DeleteAnalysis(int analysisId)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "DELETE FROM lab_analyses WHERE analysis_id = @AnalysisId";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@AnalysisId", analysisId);
                command.ExecuteNonQuery();
            }
        }
    }
}
