using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Data.Sqlite;
using Microsoft.VisualBasic.ApplicationServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace MediaStore
{
    //////SQLite Edition
    class DataAccess
    {
        // Connection String for  SQlite Edition
        static string _ConnectionString = @"Data Source=Users.db";
        static string _ConnectionStringF = @"Data Source=favorites.db";

        public static List<User> GetUser()
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
                            string email = reader.GetString(3);
                            string password = reader.GetString(5);

                            users.Add(new User(id, email, password));
                        }
                    }
                }
            }
            return users;
        }



        public static bool Login(string email, string password)
        {
            using (SqliteConnection connection = new SqliteConnection(_ConnectionString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM users WHERE email=@email AND password=@password";

                using (SqliteCommand command = new SqliteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@password", password);

                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        public static bool Register(string lastName, string firstName, string email, string phone, string password)
        {
            using (SqliteConnection connection = new SqliteConnection(_ConnectionString))
            {
                connection.Open();

                // Verifica daca utilizatorul exista deja
                string checkQuery = "SELECT COUNT(*) FROM users WHERE email=@email";
                using (SqliteCommand checkCommand = new SqliteCommand(checkQuery, connection))
                {
                    checkCommand.Parameters.AddWithValue("@email", email);

                    int existingUserCount = Convert.ToInt32(checkCommand.ExecuteScalar());

                    if (existingUserCount > 0)
                    {
                        // Utilizatorul exista deja
                        return false;
                    }
                }

                // Daca utilizatorul nu exista, il inregistreaza
                string insertQuery = "INSERT INTO users (lastName, firstName, email, phone, password) VALUES (@lastName, @firstName, @email, @phone, @password)";
                using (SqliteCommand insertCommand = new SqliteCommand(insertQuery, connection))
                {
                    insertCommand.Parameters.AddWithValue("@lastName", lastName);
                    insertCommand.Parameters.AddWithValue("@firstName", firstName);
                    insertCommand.Parameters.AddWithValue("@email", email);
                    insertCommand.Parameters.AddWithValue("@phone", phone);
                    insertCommand.Parameters.AddWithValue("@password", password);

                    int rowsAffected = insertCommand.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
        }


        /// <summary>
        /// Functie de testare
        /// </summary>
        public static void ShowAllUsers()
        {
            try
            {
                using (SqliteConnection connection = new SqliteConnection(_ConnectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM users";

                    using (SqliteCommand command = new SqliteCommand(query, connection))
                    {
                        using (SqliteDataReader reader = command.ExecuteReader())
                        {
                            string message = "Utilizatori:\n";

                            while (reader.Read())
                            {
                                int id = reader.GetInt32(0);
                                string email = reader.GetString(3);
                                string password = reader.GetString(5);

                                message += $"ID: {id}, Nume: {email}, Parolă: {password}\n";
                            }

                            MessageBox.Show(message, "Utilizatori", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"A apărut o eroare: {ex.Message}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static bool IsFavorite(string name, string price, string description)
        {
            using (SqliteConnection connection = new SqliteConnection(_ConnectionStringF))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM favoritesDatabase WHERE name=@name AND price=@price AND description=@description";

                using (SqliteCommand command = new SqliteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@price", price);
                    command.Parameters.AddWithValue("@description", description);

                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        public static bool AddFavorite(string name, string price, string description)
        {
            using (SqliteConnection connection = new SqliteConnection(_ConnectionStringF))
            {
                connection.Open();

                string query = "INSERT INTO favoritesDatabase (name, price, description) VALUES (@name, @price, @description)";

                using (SqliteCommand command = new SqliteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@price", price);
                    command.Parameters.AddWithValue("@description", description);

                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }
    }
}