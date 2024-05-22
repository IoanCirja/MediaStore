/***************************************************************************
 *                                                                         *
 *  Fisier:      Favorites.cs                                              *
 *               Funcționalitate adăugată de Cîrjă Ioan                    *
 *                                           Mihălucă Mădălina-Maria       *
 *                                           Popa Andrei                   *
 *                                           Sandu Delia-Andreea           *
 * Descriere:   Acest fișier conține clasa Favorites care definește        *
 *              comportamentul și aspectul ferestrei de afișare a         *
 *              produselor favorite ale unui utilizator.                   *
 *                                                                         *
 *  This code and information is provided "as is" without warranty of      *
 *  any kind, either expressed or implied, including but not limited       *
 *  to the implied warranties of merchantability or fitness for a          *
 *  particular purpose. You are free to use this source code in your       *
 *  applications as long as the original copyright notice is included.     *
 *                                                                         *
 ***************************************************************************/

using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaStore
{

    public partial class Favorites : Form
    {
        #region Fields

        /// <summary>
        /// Stringul de conectare la baza de date SQLite a produselor favorite
        /// </summary>
        private static string _connectionStringFavorites = @"Data Source=favorites.db";

        #endregion

        #region Constructor

        /// <summary>
        /// Constructorul clasei Favorites.
        /// </summary>
        public Favorites()
        {
            InitializeComponent();
            LoadFavorites();
        }

        #endregion

        #region Methods

        /// <summary>
        /// Metodă care încarcă produsele favorite ale utilizatorului.
        /// </summary>
        private void LoadFavorites()
        {
            List<Favorite> favorites = GetFavorite();
            DisplayFavorites(favorites);
        }

        /// <summary>
        /// Metodă care obține lista de produse favorite ale utilizatorului din baza de date.
        /// </summary>
        public static List<Favorite> GetFavorite()
        {
            List<Favorite> favorites = new List<Favorite>();

            using (SqliteConnection connection = new SqliteConnection(_connectionStringFavorites))
            {
                connection.Open();

                string query = "SELECT * FROM favoritesDatabase WHERE user = @user";

                using (SqliteCommand command = new SqliteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@user", Store.CurrentUser.Email);

                    using (SqliteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string name = reader.GetString(0);
                            string description = reader.GetString(1);
                            string price = reader.GetString(2);

                            favorites.Add(new Favorite(name, price, description, Store.CurrentUser.Email));
                        }
                    }
                }
            }
            return favorites;
        }

        /// <summary>
        /// Metoda care afișează produsele favorite ale utilizatorului în interfața grafică.
        /// </summary>
        private void DisplayFavorites(List<Favorite> favorites)
        {
            try
            {
                int count = Math.Min(favorites.Count, 6); // Maximum 6 items

                for (int i = 0; i < count; i++)
                {
                    var nameTextBox = this.Controls.Find($"name{i + 1}", true)[0] as TextBox;
                    var descriptionTextBox = this.Controls.Find($"desc{i + 1}", true)[0] as TextBox;
                    var priceTextBox = this.Controls.Find($"price{i + 1}", true)[0] as TextBox;

                    if (nameTextBox != null && descriptionTextBox != null && priceTextBox != null)
                    {
                        nameTextBox.Text = favorites[i].name;
                        descriptionTextBox.Text = favorites[i].description;
                        priceTextBox.Text = favorites[i].price;
                    }
                    else
                    {
                        MessageBox.Show($"TextBox {i + 1} not found.");
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion
    }
}
