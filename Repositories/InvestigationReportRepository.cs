using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using CrimelabHelper.Models;

namespace CrimelabHelper.Repositories
{
    public class InvestigationReportRepository
    {
        private string connectionString;

        public InvestigationReportRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public List<InvestigationReport> GetAllInvestigationReports()
        {
            List<InvestigationReport> reports = new List<InvestigationReport>();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM investigation_reports";
                MySqlCommand command = new MySqlCommand(query, connection);
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        InvestigationReport report = new InvestigationReport
                        {
                            ReportId = reader.GetInt32("report_id"),
                            CrimeId = reader.GetInt32("crime_id"),
                            Date = reader.GetDateTime("date"),
                            Description = reader.GetString("description"),
                            Conclusions = reader.GetString("conclusions"),
                            ExpertId = reader.GetInt32("expert")
                        };
                        reports.Add(report);
                    }
                }
            }
            return reports;
        }

        public InvestigationReport GetInvestigationReportById(int reportId)
        {
            InvestigationReport report = null;
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM investigation_reports WHERE ReportId = @ReportId";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@ReportId", reportId);
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        report = new InvestigationReport
                        {
                            ReportId = reader.GetInt32("report_id"),
                            CrimeId = reader.GetInt32("crime_id"),
                            Date = reader.GetDateTime("date"),
                            Description = reader.GetString("description"),
                            Conclusions = reader.GetString("conclusions"),
                            ExpertId = reader.GetInt32("expert")
                        };
                    }
                }
            }
            return report;
        }

        // Додати методи для вставки, оновлення та видалення даних
    }
}
