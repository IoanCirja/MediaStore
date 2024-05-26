/***************************************************************************
 *                                                                         *
 *  Fisier:      WebNavigatorTests.cs                                      *
 *               Functionalitate adaugata de Cîrja Ioan                    *
 *                                           Mihălucă Mădălina-Maria       *
 *                                           Popa Andrei                   *
 *                                           Sandu Delia-Andreea           *
 * Descriere:    Acest fișier conține o suită de teste folosind NUnit      *
 *               pentru a valida funcționalitatea paginii de înregistrare  *
 *               și autentificare pe site-ul www.itgalaxy.ro folosind      *
 *               Selenium WebDriver într-un browser Chrome. Testele        *
 *               acoperă diverse scenarii cum ar fi înregistrarea cu       *
 *               detalii existente, detalii valide și insuficiente,        *
 *               precum și autentificarea cu diverse formate de email      *
 *               și parole.                                                *
 *                                                                         *
 *  This code and information is provided "as is" without warranty of      *
 *  any kind, either expressed or implied, including but not limited       *
 *  to the implied warranties of merchantability or fitness for a          *
 *  particular purpose. You are free to use this source code in your       *
 *  applications as long as the original copyright notice is included.     *
 *                                                                         *
 **************************************************************************/


using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using SiteManipulation;

namespace MediaStore
{
    [TestFixture]
    public class WebNavigatorTests
    {
        #region Fields
        /// <summary>
        /// Driver-ul folosit pentru navigare.
        /// </summary>
        private IWebDriver _driver;
        /// <summary>
        /// Pagina de înregistrare.
        /// </summary>
        private RegisterPage _registerPage;
        #endregion

        #region Methods
        /// <summary>
        /// Configurarea inițială pentru fiecare test, creează o instanță nouă a driver-ului Chrome, navighează către pagina de înregistrare a site-ului www.itgalaxy.ro și inițializează pagina de înregistrare.
        /// </summary>
        [SetUp]
        public void Setup()
        {
            _driver = new ChromeDriver();
            _driver.Navigate().GoToUrl("https://www.itgalaxy.ro/cont");
            _registerPage = new RegisterPage(_driver);
        }
        /// <summary>
        /// Închide sesiunea și distruge obiectul driver-ului Chrome după fiecare test.
        /// </summary>
        [TearDown]
        public void TearDown()
        {
            _driver.Quit();
            _driver.Dispose();
        }
        #endregion

        #region Tests
        /// <summary>
        /// Testează înregistrarea unui utilizator cu detalii deja existente în sistem.
        /// </summary>
        /// <returns>False dacă datele există deja.</returns>
        [Test]
        public void Register_WithDetailsAlreadyExisting_Test()
        {
            string firstName = "Sandu";
            string lastName = "Alexandra";
            string phoneNumber = "0712345678";
            string email = "andreea.delia11@yahoo.com";
            string password = "parola";

            _registerPage.Register(firstName, lastName, phoneNumber, email, password);

            Thread.Sleep(4000);
            var errorMessageElement = _driver.FindElement(By.XPath("//*[@id='container_main']/div/div[1]/div[2]/div/ul/li[1]"));
            Assert.IsTrue(errorMessageElement.Displayed, "The expected error message is not visible.");
        }
        /// <summary>
        /// Testează înregistrarea unui utilizator cu detalii valide.
        /// </summary>
        /// <returns>True dacă înregistrarea a reușit.</returns>
        [Test]
        public void Register_WithValidDetails_Test()
        {
            string firstName = "Ionescu";
            string lastName = "Ana";
            string phoneNumber = "0712345648";
            string email = "sandudeliandreea11@gmail.com";
            string password = "parola123";

            _registerPage.Register(firstName, lastName, phoneNumber, email, password);

            Thread.Sleep(2000);
            var errorMessageElement = _driver.FindElement(By.XPath("//*[@id='container_main']/div/div[1]/div[2]/div/ul/li[1]"));
            Assert.IsTrue(errorMessageElement.Displayed, "The expected error message is not visible.");
        }
        /// <summary>
        /// Testează înregistrarea unui utilizator cu detalii incomplete.
        /// </summary>
        /// <returns>True dacă înregistrarea nu a reușit.</returns>
        [Test]
        public void Register_WithNotEnoughDetails_Test()
        {
            string firstName = "Ionescu";
            string lastName = "Ana";
            string phoneNumber = "0712345648";
            string email = "sandudeliaandreea11@gmail.com";
            string password = "";

            _registerPage.Register(firstName, lastName, phoneNumber, email, password);

            Thread.Sleep(2000);  

            var errorMessageElement = _driver.FindElement(By.XPath("//*[@id='container_main']/div/div[1]/div[2]/div/ul/li[1]"));
            Assert.IsTrue(errorMessageElement.Displayed, "The expected error message is not visible.");

        }

        /// <summary>
        /// Testează autentificarea unui utilizator cu date valide. 
        /// </summary>
        /// <returns>True dacă logarea a reușit.</returns>
        [Test]
        public void Login_WithValidCredentials_Test()
        {
            string email = "sandudelia60@gmail.com";
            string password = "sandudelia60";

            _registerPage.Login(email, password);

            Thread.Sleep(2000);
            Assert.IsTrue(_driver.Url.Contains("https://www.itgalaxy.ro/cont"));
        }
        /// <summary>
        /// Testează autentificarea unui utilizator cu date invalide. 
        /// </summary>
        /// <returns>True dacă logarea nu a reușit.</returns>
        [Test]
        public void Login_WithInvalidCredentials_Test()
        {
            string email = "sandudelia60@gmail.com";
            string password = "parola";

            _registerPage.Login(email, password);

            Thread.Sleep(2000);
            Assert.IsFalse(_driver.Url.Contains("Parola sau username-ul sunt gresite. Accesul va fi blocat dupa mai multe incercari nereusite."));

        }
        /// <summary>
        /// Testează autentificarea unui utilizator cu format invalid al adresei de email.
        /// </summary>
        /// <returns>False dacă logarea nu a reușit.</returns>
        [Test]
        public void Login_WithInvalidEmailFormat_Test()
        {
            string email = "sandudelia60@gmail";
            string password = "parola";

            _registerPage.Login(email, password);

            Thread.Sleep(2000);
            Assert.IsFalse(_driver.Url.Contains("Adresa de e-mail nu este valida!"));

        }
        #endregion
    }
}
