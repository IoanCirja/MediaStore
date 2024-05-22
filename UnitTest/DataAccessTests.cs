using NUnit.Framework;
using System.Collections.Generic;
using MediaStore;
using Microsoft.Data.Sqlite;
using SiteManipulation;

namespace MediaStore
{
    [TestFixture]
    public class DataAccessTests
    {
        private const string ConnectionString = @"Data Source=Users.db";
        private const string ConnectionStringF = @"Data Source=favorites.db";

        public DataAccessTests()
        {
            DataAccess._ConnectionString = ConnectionString;
            DataAccess._ConnectionStringF = ConnectionStringF;

            InitializeDatabase();
        }

        [SetUp]
        public void Setup()
        {
        }

        [TearDown]
        public void TearDown()
        {
            
        }
        private void InitializeDatabase()
        {
            using (var connection = new SqliteConnection(ConnectionString))
            {
                connection.Open();
                string query = "SELECT * FROM users";

                var command = new SqliteCommand(query, connection);
                
            }

            using (var connection = new SqliteConnection(ConnectionStringF))
            {
                connection.Open();

                string query = "SELECT * FROM favoritesDatabase";

                var command = new SqliteCommand(query, connection);

            }
        }

        [Test]
        public void GetUser_Test()
        {
            Setup();

            List<User> users = DataAccess.GetUser();

            Assert.IsNotNull(users);
            Assert.IsTrue(users.Count > 0);
        }

        [Test]
        public void Login_WithValidCredentials_Test()
        {
            string email = "sandudelia60@gmail.com";
            string password = "sandudelia60";

            bool result = DataAccess.Login(email, password);

            Assert.IsTrue(result);
        }

        [Test]
        public void Login_WithInvalidCredentials_Test()
        {
            string email = "sandudelia60@gmail.com";
            string password = "password";

            bool result = DataAccess.Login(email, password);

            Assert.IsFalse(result);
        }

        [Test]
        public void Login_WithInvalidEmailFormat_Test()
        {
            string email = "sandudelia60@gmail";
            string password = "sandudelia60";

            bool result = DataAccess.Login(email, password);

            Assert.IsTrue(result);
        }

        [Test]
        public void Register_WithNewUser_Test()
        {
            string lastName = "Ionescu";
            string firstName = "Ana";
            string email = "anaionescu@gmail.com";
            string phone = "0712345678";
            string password = "password123";

            bool result = DataAccess.Register(lastName, firstName, email, phone, password);

            Assert.IsTrue(result);
        }

        [Test]
        public void Register_WithExistingUser_Test()
        {
            string lastName = "Sandu";
            string firstName = "Delia";
            string email = "sandudelia60@gmail.com";
            string phone = "0747657187";
            string password = "sandudelia60";

            bool result = DataAccess.Register(lastName, firstName, email, phone, password);

            Assert.IsFalse(result);
        }
        [Test]
        public void Register_WithWrongFormatForPhone_Test()
        {
            string lastName = "Sandu";
            string firstName = "Delia";
            string email = "sandudelia60@gmail.com";
            string phone = "1234";
            string password = "sandudelia60";

            bool result = DataAccess.Register(lastName, firstName, email, phone, password);

            Assert.IsTrue(result);
        }

        [Test]
        public void Register_WithWrongFormatForEmail_Test()
        {
            string lastName = "Sandu";
            string firstName = "Delia";
            string email = "sandudelia60@";
            string phone = "0745678911";
            string password = "sandudelia60";

            bool result = DataAccess.Register(lastName, firstName, email, phone, password);

            Assert.IsTrue(result);
        }

        [Test]
        public void IsFavorite_WithExistingFavorite_Test()
        {
            string name = "Laptop ASUS Vivobook X1505ZA Afisaj OLED FHD 15.6 inch Intel Core i5-1235U 8GB 512GB SSD Free Dos Indie Black";
            string price = "2.597,99";
            string description = "Serie procesor: Intel Core i5 Diagonala display: 15.6 Inch Rezolutie: 1920 x 1080 Pixeli Format display: Full HD Touch screen: Nu Capacitate memorie: 8 GB Tip Stocare: SSD Capacitate SSD: 512 GB";
            string user = "sandudelia60@gmail.com";

            bool result = DataAccess.IsFavorite(name, price, description, user);

            Assert.IsTrue(result);
        }

        [Test]
        public void IsFavorite_WithNonExistingFavorite_Test()
        {
            string name = "Laptop Acer Aspire 3 FHD 15.6 inch Intel Core i5-1235U 8GB 512GB SSD GeForce MX550 Pure Silver";
            string price = "2.162,99 ";
            string description = "Serie procesor: Intel Core i5 Frecventa nominala: 3.3 GHz Diagonala display: 15.6 Inch Rezolutie: 1920 x 1080 Pixeli Format display: Full HD Touch screen: Nu Capacitate memorie: 8 GBTip Stocare: SSD";
            string user = "ionescuana@gmail.com";

            bool result = DataAccess.IsFavorite(name, price, description, user);

            Assert.IsFalse(result);
        }

        [Test]
        public void AddFavorite_Test()
        {
            string name = "LaptopNou";
            string price = "200";
            string description = "Descriere";
            string user = "sandudelia60@gmail.com";

            bool result = DataAccess.AddFavorite(name, price, description, user);

            Assert.IsTrue(result);
        }

        [Test]
        public void RemoveFavorite_Test()
        { 
            string name = "LaptopNou";
            string price = "200";
            string description = "Descriere";
            string user = "sandudelia60@gmail.com";

            bool result = DataAccess.RemoveFavorite(name, price, description, user);

            Assert.IsTrue(result);
        }
    }
}
