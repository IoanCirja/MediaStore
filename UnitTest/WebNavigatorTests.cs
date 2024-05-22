using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using SiteManipulation;

namespace MediaStore
{
    [TestFixture]
    public class RegisterPageTests
    {
        private IWebDriver _driver;
        private RegisterPage _registerPage;

        [SetUp]
        public void Setup()
        {
            _driver = new ChromeDriver();
            _driver.Navigate().GoToUrl("https://www.itgalaxy.ro/cont"); 
            _registerPage = new RegisterPage(_driver);
        }

        [TearDown]
        public void TearDown()
        {
            _driver.Quit();
            _driver.Dispose();
        }

        [Test]
        public void Register_WithDetailsAlreadyExisting_Test()
        {
            //returneaza false daca datele pentru cont exista deja
            string firstName = "Sandu";
            string lastName = "Alexandra";
            string phoneNumber = "0712345678";
            string email = "andreea.delia11@yahoo.com";
            string password = "parola";

            _registerPage.Register(firstName, lastName, phoneNumber, email, password);

            Thread.Sleep(2000); 
            Assert.IsTrue(_driver.Url.Contains("Deja exista un cont inregistrat cu aceasta adresa de email"));
        }
        [Test]
        public void Register_WithValidDetails_Test()
        {
            //pentru ca testul sa fie passed, trebuie puse date noi de fiecare data cand este rulat
            string firstName = "Ionescu";
            string lastName = "Ana";
            string phoneNumber = "0712345648";
            string email = "sandudeliandreea11@gmail.com";
            string password = "parola123";

            _registerPage.Register(firstName, lastName, phoneNumber, email, password);

            Thread.Sleep(2000);
            Assert.IsTrue(_driver.Url.Contains("https://www.itgalaxy.ro/cont"));
        }

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
            Assert.IsTrue(_driver.Url.Contains("Va rugam sa completati parola"));
        }

        [Test]
        public void Login_WithValidCredentials_Test()
        {
            string email = "sandudelia60@gmail.com";
            string password = "sandudelia60";

            _registerPage.Login(email, password);

            Thread.Sleep(2000); 
            Assert.IsTrue(_driver.Url.Contains("https://www.itgalaxy.ro/cont")); 
        }

        [Test]
        public void Login_WithInvalidCredentials_Test()
        {
            string email = "sandudelia60@gmail.com";
            string password = "parola";

            _registerPage.Login(email, password);

            Thread.Sleep(2000); 
            Assert.IsFalse(_driver.Url.Contains("Parola sau username-ul sunt gresite. Accesul va fi blocat dupa mai multe incercari nereusite."));
            
        }

        [Test]
        public void Login_WithInvalidEmailFormat_Test()
        {
            string email = "sandudelia60@gmail";
            string password = "parola";

            _registerPage.Login(email, password);

            Thread.Sleep(2000);
            Assert.IsFalse(_driver.Url.Contains("Adresa de e-mail nu este valida!"));

        }
    }
}
