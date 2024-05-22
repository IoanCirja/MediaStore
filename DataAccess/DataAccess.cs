/***************************************************************************
 *                                                                         *
 *  Fisier:      DataAccess.cs                                             *
 *               Functionalitate adaugata de Cîrja Ioan                    *
 *                                           Mihălucă Mădălina-Maria       *
 *                                           Popa Andrei                   *
 *                                           Sandu Delia-Andreea           *
 * Descriere:   Acest fișier conține clasa DataAccess care gestionează     *
 *              interacțiunea cu bazele de date SQLite pentru aplicația    *
 *              MediaStore. Clasa oferă funcționalități pentru obținerea   *
 *              utilizatorilor, autentificare, înregistrare și gestionarea *
 *              favoritelor utilizatorilor.                                *
 *                                                                         *
 *  This code and information is provided "as is" without warranty of      *
 *  any kind, either expressed or implied, including but not limited       *
 *  to the implied warranties of merchantability or fitness for a          *
 *  particular purpose. You are free to use this source code in your       *
 *  applications as long as the original copyright notice is included.     *
 *                                                                         *
 **************************************************************************/


using System;
using System.Collections.Generic;
using System.Data;
using System.Windows;
using Microsoft.Data.Sqlite;


namespace MediaStore
{
    public class DataAccess
    {
        #region Fields

        /// <summary>
        /// Stringul de conectare la baza de date SQLite a utilizatorilor
        /// </summary>
        private static string _connectionStringUsers = @"Data Source=Users.db";

        /// <summary>
        /// Stringul de conectare la baza de date SQLite a produselor favorite
        /// </summary>
        private static string _connectionStringFavorites = @"Data Source=favorites.db";
      
        #endregion

        #region Methods

        /// <summary>
        /// Metodă care obține lista de utilizatori din baza de date Users.
        /// </summary>
        /// <returns>Lista de utilizatori.</returns>
        public static List<User> GetUser()
        {
            // Lista pentru a stoca utilizatorii
            List<User> users = new List<User>();

            // Deschide conexiunea la baza de date
            using (SqliteConnection connection = new SqliteConnection(_connectionStringUsers))
            {
                connection.Open();

                // Query-ul pentru a selecta toți utilizatorii
                string query = "SELECT * FROM users";

                using (SqliteCommand command = new SqliteCommand(query, connection))
                {
                    // Citește rezultatele și adaugă utilizatorii în listă
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

        /// <summary>
        /// Metodă care verifică dacă emailul și parola corespund unui utilizator din baza de date.
        /// </summary>
        /// <param name="email">Emailul utilizatorului.</param>
        /// <param name="password">Parola utilizatorului.</param>
        /// <returns>True dacă autentificarea este reușită, False altfel.</returns>
        public static bool Login(string email, string password)
        {
            // Deschide conexiunea la baza de date
            using (SqliteConnection connection = new SqliteConnection(_connectionStringUsers))
            {
                connection.Open();

                // Query-ul pentru a verifica autentificarea
                string query = "SELECT COUNT(*) FROM users WHERE email=@email AND password=@password";

                // Creează și execută comanda
                using (SqliteCommand command = new SqliteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@password", password);

                    // Execută query-ul și returnează rezultatul
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        /// <summary>
        /// Metodă care înregistrează un nou utilizator în baza de date.
        /// </summary>
        /// <param name="lastName">Numele de familie al utilizatorului.</param>
        /// <param name="firstName">Prenumele utilizatorului.</param>
        /// <param name="email">Emailul utilizatorului.</param>
        /// <param name="phone">Telefonul utilizatorului.</param>
        /// <param name="password">Parola utilizatorului.</param>
        /// <returns>True dacă înregistrarea este reușită, False altfel.</returns>
        public static bool Register(string lastName, string firstName, string email, string phone, string password)
        {
            // Deschide conexiunea la baza de date
            using (SqliteConnection connection = new SqliteConnection(_connectionStringUsers))
            {
                connection.Open();

                // Verifică dacă utilizatorul există deja
                string checkQuery = "SELECT COUNT(*) FROM users WHERE email=@email";
                using (SqliteCommand checkCommand = new SqliteCommand(checkQuery, connection))
                {
                    checkCommand.Parameters.AddWithValue("@email", email);

                    int existingUserCount = Convert.ToInt32(checkCommand.ExecuteScalar());

                    // Dacă utilizatorul există, returnează false
                    if (existingUserCount > 0)
                    {
                        return false;
                    }
                }

                // Dacă utilizatorul nu există, îl înregistrează
                string insertQuery = "INSERT INTO users (lastName, firstName, email, phone, password) VALUES (@lastName, @firstName, @email, @phone, @password)";
                using (SqliteCommand insertCommand = new SqliteCommand(insertQuery, connection))
                {
                    insertCommand.Parameters.AddWithValue("@lastName", lastName);
                    insertCommand.Parameters.AddWithValue("@firstName", firstName);
                    insertCommand.Parameters.AddWithValue("@email", email);
                    insertCommand.Parameters.AddWithValue("@phone", phone);
                    insertCommand.Parameters.AddWithValue("@password", password);
                    
                    // Execută query-ul și returnează rezultatul
                    int rowsAffected = insertCommand.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
        }

        /// <summary>
        /// Metodă de testare pentru afișarea tuturor utilizatorilor.
        /// </summary>
        public static void ShowAllUsers()
        {
            try
            {
                using (SqliteConnection connection = new SqliteConnection(_connectionStringUsers))
                {
                    connection.Open();

                    string query = "SELECT * FROM users";

                    using (SqliteCommand command = new SqliteCommand(query, connection))
                    {
                        using (SqliteDataReader reader = command.ExecuteReader())
                        {
                            string message = "Utilizatori:\n";

                            // Citește rezultatele și construiește mesajul
                            while (reader.Read())
                            {
                                int id = reader.GetInt32(0);
                                string email = reader.GetString(3);
                                string password = reader.GetString(5);

                                message += $"ID: {id}, Nume: {email}, Parolă: {password}\n";
                            }

                            // Afișează mesajul (comentat pentru a evita erori)
                            //MessageBox.Show(message, "Utilizatori", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Afișează eroarea (comentat pentru a evita erori)
                //MessageBox.Show($"A apărut o eroare: {ex.Message}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Metodă care verifică dacă un produs este în lista de favorite.
        /// </summary>
        /// <param name="name">Numele elementului.</param>
        /// <param name="price">Prețul elementului.</param>
        /// <param name="description">Descrierea elementului.</param>
        /// <param name="user">Utilizatorul care a adăugat elementul.</param>
        /// <returns>True dacă elementul este în lista de favorite, False altfel.</returns>
        public static bool IsFavorite(string name, string price, string description, string user)
        {
            // Deschide conexiunea la baza de date a favoritelor
            using (SqliteConnection connection = new SqliteConnection(_connectionStringFavorites))
            {
                connection.Open();
                // Query-ul pentru a verifica dacă elementul este în lista de favorite
                string query = "SELECT COUNT(*) FROM favoritesDatabase WHERE name=@name AND price=@price AND description=@description AND user=@user";

                // Creează și execută comanda
                using (SqliteCommand command = new SqliteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@price", price);
                    command.Parameters.AddWithValue("@description", description);
                    command.Parameters.AddWithValue("@user", user);

                    // Execută query-ul și returnează rezultatul
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        /// <summary>
        /// Metodă care adaugă un produs în lista de favorite.
        /// </summary>
        /// <param name="name">Numele elementului.</param>
        /// <param name="price">Prețul elementului.</param>
        /// <param name="description">Descrierea elementului.</param>
        /// <param name="user">Utilizatorul care adaugă elementul.</param>
        /// <returns>True dacă adăugarea este reușită, False altfel.</returns>
        public static bool AddFavorite(string name, string price, string description, string user)
        {
            // Deschide conexiunea la baza de date a favoritelor
            using (SqliteConnection connection = new SqliteConnection(_connectionStringFavorites))
            {
                connection.Open();

                // Query-ul pentru a adăuga un produs în lista de favorite
                string query = "INSERT INTO favoritesDatabase (name, price, description, user) VALUES (@name, @price, @description, @user)";

                // Creează și execută comanda
                using (SqliteCommand command = new SqliteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@price", price);
                    command.Parameters.AddWithValue("@description", description);
                    command.Parameters.AddWithValue("@user", user);

                    // Execută query-ul și returnează rezultatul
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }

        /// <summary>
        /// Metodă care elimină un produs din lista de favorite.
        /// </summary>
        /// <param name="name">Numele elementului.</param>
        /// <param name="price">Prețul elementului.</param>
        /// <param name="description">Descrierea elementului.</param>
        /// <param name="user">Utilizatorul care a adăugat elementul.</param>
        /// <returns>True dacă eliminarea este reușită, False altfel.</returns>
        public static bool RemoveFavorite(string name, string price, string description, string user)
        {
            // Deschide conexiunea la baza de date a favoritelor
            using (SqliteConnection connection = new SqliteConnection(_connectionStringFavorites))
            {
                connection.Open();

                // Query-ul pentru a elimina un produs în lista de favorite
                string query = "DELETE FROM favoritesDatabase WHERE name=@name";

                using (SqliteCommand command = new SqliteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@price", price);
                    command.Parameters.AddWithValue("@description", description);
                    command.Parameters.AddWithValue("@user", user);

                    // Execută query-ul și returnează rezultatul
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }

        #endregion
    }
}
