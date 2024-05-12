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
                            CrimeId = reader.GetInt32("crime_id"),
                            Description = reader.GetString("description"),
                            Date = reader.GetDateTime("date"),
                            Type = reader.GetString("type")
                        };
                        crimes.Add(crime);
                    }
                }
            }
            return crimes;
        }

        public Crime GetCrimeById(int crimeId)
        {
            Crime crime = null;
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM crimes WHERE crime_id = @CrimeId";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@CrimeId", crimeId);
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        crime = new Crime
                        {
                            CrimeId = reader.GetInt32("crime_id"),
                            Description = reader.GetString("description"),
                            Date = reader.GetDateTime("date"),
                            Type = reader.GetString("type")
                        };
                    }
                }
            }
            return crime;
        }

        public void AddCrime(Crime crime)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO crimes (description, date, type) VALUES (@Description, @Date, @Type)";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Description", crime.Description);
                command.Parameters.AddWithValue("@Date", crime.Date);
                command.Parameters.AddWithValue("@Type", crime.Type);
                command.ExecuteNonQuery();
            }
        }

        public void UpdateCrime(Crime crime)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE crimes SET description = @Description, date = @Date, type = @Type WHERE crime_Id = @CrimeId";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Description", crime.Description);
                command.Parameters.AddWithValue("@Date", crime.Date);
                command.Parameters.AddWithValue("@Type", crime.Type);
                command.Parameters.AddWithValue("@CrimeId", crime.CrimeId);
                command.ExecuteNonQuery();
            }
        }

        public void DeleteCrime(int crimeId)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "DELETE FROM crimes WHERE crime_Id = @CrimeId";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@CrimeId", crimeId);
                command.ExecuteNonQuery();
            }
        }
    }
}
