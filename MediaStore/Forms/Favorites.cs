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
        static string _ConnectionStringF = @"Data Source=favorites.db";
        public Favorites()
        {
            InitializeComponent();
            LoadFavorites();
        }

        private void LoadFavorites()
        {
            List<Favorite> favorites = GetFavorite();
            DisplayFavorites(favorites);
        }

        public static List<Favorite> GetFavorite()
        {
            List<Favorite> favorites = new List<Favorite>();

            using (SqliteConnection connection = new SqliteConnection(_ConnectionStringF))
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

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void Favorites_Load(object sender, EventArgs e)
        {

        }
    }
}
