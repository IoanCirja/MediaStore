using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.Sqlite;
using Microsoft.VisualBasic.ApplicationServices;


namespace MediaStore
{
    //////SQLite Edition
    class DataAccess
    {
        // Connection String for  SQlite Edition
        static string _ConnectionString = @"Data Source=usersDatabase.db";

        //static SqliteConnection _Connection = null;

        //public static SqliteConnection Connection
        //{
        //    get
        //    {
        //        if (_Connection == null)
        //        {
        //            _Connection = new SqliteConnection(_ConnectionString);
        //            _Connection.Open();

        //            return _Connection;
        //        }
        //        else if (_Connection.State != System.Data.ConnectionState.Open)
        //        {
        //            _Connection.Open();

        //            return _Connection;
        //        }
        //        else
        //        {
        //            return _Connection;
        //        }
        //    }
        //}

        public static List<User> GetAllUsers()
        {
            List<User> users = new List<User>();

            using (SqliteConnection connection = new SqliteConnection(_ConnectionString))
            {
                connection.Open();

                string query = "SELECT * FROM users";

                using (SqliteCommand command = new SqliteCommand(query, connection))
                {
                    using (SqliteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = reader.GetInt32(0);
                            string name = reader.GetString(1);
                            string password = reader.GetString(2);

                            users.Add(new User(id, name, password));
                        }
                    }
                }
            }

            return users;
        }

        public static bool Login(string username, string password)
        {
            using (SqliteConnection connection = new SqliteConnection(_ConnectionString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM users WHERE name=@username AND password=@password";

                using (SqliteCommand command = new SqliteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);

                    int count = Convert.ToInt32(command.ExecuteScalar());

                    return count > 0;
                }
            }
        }

        public static bool Register(string username, string password)
        {
            using (SqliteConnection connection = new SqliteConnection(_ConnectionString))
            {
                connection.Open();

                // Verifică dacă utilizatorul există deja
                string checkQuery = "SELECT COUNT(*) FROM users WHERE name=@username";
                using (SqliteCommand checkCommand = new SqliteCommand(checkQuery, connection))
                {
                    checkCommand.Parameters.AddWithValue("@username", username);

                    int existingUserCount = Convert.ToInt32(checkCommand.ExecuteScalar());

                    if (existingUserCount > 0)
                    {
                        // Utilizatorul există deja
                        return false;
                    }
                }

                // Dacă utilizatorul nu există, îl înregistrează
                string insertQuery = "INSERT INTO users (name, password) VALUES (@username, @password)";
                using (SqliteCommand insertCommand = new SqliteCommand(insertQuery, connection))
                {
                    insertCommand.Parameters.AddWithValue("@username", username);
                    insertCommand.Parameters.AddWithValue("@password", password);

                    int rowsAffected = insertCommand.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
        }

    }
}