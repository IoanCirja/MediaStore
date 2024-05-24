/***************************************************************************
 *                                                                         *
 *  Fisier:      DataAccessTests.cs                                        *
 *               Functionalitate adaugata de Cîrja Ioan                    *
 *                                           Mihălucă Mădălina-Maria       *
 *                                           Popa Andrei                   *
 *                                           Sandu Delia-Andreea           *
 * Descriere:    În acest fișier sunt definite teste unitare care          *
 *               verific? diverse funcționalit??i ale clasei DataAccess    *
 *               din cadrul aplica?iei, inclusiv autentificarea            * 
 *               utilizatorilor, înregistrarea de noi utilizatori,         *
 *               gestionarea preferin?elor de articole favorite ?i         *
 *               interac?iunea cu bazele de date pentru utilizatori ?i     *
 *               produse favorite.                                         *
 *                                                                         *
 *  This code and information is provided "as is" without warranty of      *
 *  any kind, either expressed or implied, including but not limited       *
 *  to the implied warranties of merchantability or fitness for a          *
 *  particular purpose. You are free to use this source code in your       *
 *  applications as long as the original copyright notice is included.     *
 *                                                                         *
 **************************************************************************/


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
        #region Methods
        /// <summary>
        /// Constructorul pentru clasa de teste DataAccessTests.
        /// </summary>
        public DataAccessTests()
        {
            InitializeDatabase();
        }
        /// <summary>
        /// Metodă care ini?ializeaz? bazele de date.
        /// </summary>
        private void InitializeDatabase()
        {
            // Deschiderea unei conexiuni c?tre baza de date a utilizatorilor 
            using (var connection = new SqliteConnection(DataAccess._connectionStringUsers))
            {
                connection.Open();
                string query = "SELECT * FROM users";

                var command = new SqliteCommand(query, connection);

            }
            // Deschiderea unei conexiuni c?tre baza de date a produselor favorite 
            using (var connection = new SqliteConnection(DataAccess._connectionStringFavorites))
            {
                connection.Open();

                string query = "SELECT * FROM favoritesDatabase";

                var command = new SqliteCommand(query, connection);

            }
        }
        #endregion

        #region Tests
        /// <summary>
        /// Testează metoda GetUser pentru a verifica dacă returnează o listă de utilizatori care nu este nulă și conține cel puțin un utilizator.
        /// </summary>
        [Test]
        public void GetUser_Test()
        {

            List<User> users = DataAccess.GetUser();

            Assert.IsNotNull(users);
            Assert.IsTrue(users.Count > 0);
        }
        /// <summary>
        /// Testeaz? metoda Login cu date valide pentru a verifica dac? se reu?e?te autentificarea.
        /// </summary>
        /// <returns>True dac? autentificarea a reu?it.</returns>
        [Test]
        public void Login_WithValidCredentials_Test()
        {
            string email = "sandudelia60@gmail.com";
            string password = "sandudelia60";

            bool result = DataAccess.Login(email, password);

            Assert.IsTrue(result);
        }
        /// <summary>
        /// Testeaz? metoda Login cu date invalide pentru a verifica dac? autentificarea e?ueaz?.
        /// </summary>
        /// <returns>True dac? autentificarea a esuat.</returns>
        [Test]
        public void Login_WithInvalidCredentials_Test()
        {
            string email = "sandudelia60@gmail.com";
            string password = "password";

            bool result = DataAccess.Login(email, password);

            Assert.IsFalse(result);
        }
        /// <summary>
        /// Testeaz? metoda Login cu un format invalid pentru email pentru a verifica dac? autentificarea reu?e?te.
        /// </summary>
        /// <returns>False daca autentificarea nu a reu?it.</returns>
        [Test]
        public void Login_WithInvalidEmailFormat_Test()
        {
            string email = "sandudelia60@gmail";
            string password = "sandudelia60";

            bool result = DataAccess.Login(email, password);

            Assert.IsTrue(result);
        }
        /// <summary>
        /// Testeaz? metoda Register pentru a verifica dac? un nou utilizator poate fi înregistrat cu succes.
        /// </summary>
        /// <returns>True dac? înregistrarea a reu?it.</returns>
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
        /// <summary>
        /// Testeaz? metoda Register pentru a verifica dac? înregistrarea unui utilizator deja existent e?ueaz?.
        /// </summary>
        /// <returns>True dac? înregistrarea a e?uat.</returns>
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
        /// <summary>
        /// Testeaz? metoda Register pentru a verifica dac? înregistrarea unui utilizator cu un format gre?it pentru telefon reu?e?te.
        /// </summary>
        /// <returns>False dac? înregistrarea a e?uat.</returns>
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
        /// <summary>
        /// Testeaz? metoda Register pentru a verifica dac? înregistrarea unui utilizator cu un format gre?it pentru email reu?e?te.
        /// </summary>
        /// <returns>False dac? înregistrarea a e?uat.</returns>
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
        /// <summary>
        /// Testeaz? metoda IsFavorite pentru a verifica dac? un articol favorit este g?sit.
        /// </summary>
        /// <returns>True dac? articolul se g?se?te în baza de date.</returns>
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
        /// <summary>
        /// Testeaz? metoda IsFavorite pentru a verifica dac? un articol favorit inexistent este g?sit.
        /// </summary>
        /// <returns>True dac? articolul nu se g?se?te în baza de date.</returns>
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
        /// <summary>
        /// Testeaz? metoda AddFavorite pentru a verifica dac? un articol poate fi ad?ugat la favorite cu succes.
        /// </summary>
        /// /// <returns>True dac? articolul a putut fi ad?ugat în baza de date.</returns>
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
        /// <summary>
        /// Testeaz? metoda RemoveFavorite pentru a verifica dac? un articol poate fi ?ters din lista de favorite cu succes.
        /// </summary>
        /// /// <returns>True dac? articolul a putut fi ?ters din baza de date.</returns>
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
        #endregion
    }
}
