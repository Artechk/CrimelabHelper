using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using CrimelabHelper.Models;

namespace CrimelabHelper.Repositories
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
                            SuspectId = reader.GetInt32("suspect_id"),
                            Name = reader.GetString("name"),
                            Birth = reader.GetDateTime("birth_date"),
                            Address = reader.GetString("address"),
                            Status = reader.GetString("status"),
                            CrimeId = reader.GetInt32("crime_id")
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
                string query = "SELECT * FROM suspects WHERE suspect_id = @SuspectId";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@SuspectId", suspectId);
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        suspect = new Suspect
                        {
                            SuspectId = reader.GetInt32("suspect_id"),
                            Name = reader.GetString("name"),
                            Birth = reader.GetDateTime("birth_date"),
                            Address = reader.GetString("address"),
                            Status = reader.GetString("status"),
                            CrimeId = reader.GetInt32("crime_id")
                        };
                    }
                }
            }
            return suspect;
        }

        public void AddSuspect(Suspect suspect)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO suspects (name, birth_date, address, status, crime_id) VALUES (@Name, @BirthDate, @Address, @Status, @CrimeId)";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", suspect.Name);
                command.Parameters.AddWithValue("@BirthDate", suspect.Birth);
                command.Parameters.AddWithValue("@Address", suspect.Address);
                command.Parameters.AddWithValue("@Status", suspect.Status);
                command.Parameters.AddWithValue("@CrimeId", suspect.CrimeId);
                command.ExecuteNonQuery();
            }
        }

        public void UpdateSuspect(Suspect suspect)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE suspects SET name = @Name, birth_date = @BirthDate, address = @Address, status = @Status, crime_id = @CrimeId WHERE suspect_id = @SuspectId";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", suspect.Name);
                command.Parameters.AddWithValue("@BirthDate", suspect.Birth);
                command.Parameters.AddWithValue("@Address", suspect.Address);
                command.Parameters.AddWithValue("@Status", suspect.Status);
                command.Parameters.AddWithValue("@CrimeId", suspect.CrimeId);
                command.Parameters.AddWithValue("@SuspectId", suspect.SuspectId);
                command.ExecuteNonQuery();
            }
        }

        public void DeleteSuspect(int suspectId)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "DELETE FROM suspects WHERE suspect_id = @SuspectId";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@SuspectId", suspectId);
                command.ExecuteNonQuery();
            }
        }
    }
}
