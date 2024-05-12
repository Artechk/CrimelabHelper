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
                            AnalysisId = reader.GetInt32("AnalysisId"),
                            EvidenceId = reader.GetInt32("EvidenceId"),
                            Date = reader.GetDateTime("Date"),
                            Results = reader.GetString("Results"),
                            ChemicalSubstances = reader.GetString("ChemicalSubstances")
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
                string query = "SELECT * FROM lab_analyses WHERE AnalysisId = @AnalysisId";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@AnalysisId", analysisId);
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        analysis = new LabAnalysis
                        {
                            AnalysisId = reader.GetInt32("AnalysisId"),
                            EvidenceId = reader.GetInt32("EvidenceId"),
                            Date = reader.GetDateTime("Date"),
                            Results = reader.GetString("Results"),
                            ChemicalSubstances = reader.GetString("ChemicalSubstances")
                        };
                    }
                }
            }
            return analysis;
        }

        // Додати методи для вставки, оновлення та видалення даних
    }
}
