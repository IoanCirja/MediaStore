/***************************************************************************
 *                                                                         *
 *  Fisier:      WebNavigator.cs                                           *
 *               Functionalitate adaugata de Cîrja Ioan                    *
 *                                           Mihălucă Mădălina-Maria       *
 *                                           Popa Andrei                   *
 *                                           Sandu Delia-Andreea           *
 * Descriere:   Acest fișier definește clasa WebNavigator, care            *
 *              inițializează un _driver Chrome pentru navigarea pe site-ul *
 *              "itgalaxy.ro" și oferă metode pentru autentificarea și     *
 *              înregistrarea utilizatorilor, utilizând instanțe ale       *
 *              claselor HomePage și RegisterPage.                         *
 *                                                                         *
 *  This code and information is provided "as is" without warranty of      *
 *  any kind, either expressed or implied, including but not limited       *
 *  to the implied warranties of merchantability or fitness for a          *
 *  particular purpose. You are free to use this source code in your       *
 *  applications as long as the original copyright notice is included.     *
 *                                                                         *
 **************************************************************************/


using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteManipulation
{
    public class WebNavigator
    {
        #region Fields

        /// <summary>
        /// Driver-ul folosit pentru navigare.
        /// </summary>
        private ChromeDriver _driver;
        /// <summary>
        /// Pagina principală.
        /// </summary>
        private HomePage _homePage;
        /// <summary>
        /// Pagina pentru înregistrare.
        /// </summary>
        private RegisterPage _registerPage;

        #endregion

        #region Methods

        /// <summary>
        /// Constructorul clasei WebNavigator.
        /// </summary>
        public WebNavigator()
        {
            ChromeOptions options = new ChromeOptions();

            var chromeDriverService = ChromeDriverService.CreateDefaultService();
            chromeDriverService.HideCommandPromptWindow = true; //inchidere fereastra cmd

            _driver = new ChromeDriver(chromeDriverService, options);
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl("https://www.itgalaxy.ro/"); //setup

            _homePage = new HomePage(_driver);
            _registerPage = new RegisterPage(_driver);

        }

        /// <summary>
        /// Metodă care autentifică un utilizator cu email-ul și parola furnizate.
        /// </summary>
        /// <param name="email">Adresa de email a utilizatorului.</param>
        /// <param name="password">Parola utilizatorului.</param>
        public void Login(string email, string password)
        {
            _homePage.GoRegister();
            Thread.Sleep(3000);
            _registerPage.Login(email, password);

        }
        
        /// <summary>
        /// Metdoă care înregistrează un nou utilizator cu detaliile furnizate.
        /// </summary>
        /// <param name="firstName">Prenumele utilizatorului.</param>
        /// <param name="lastName">Numele de familie al utilizatorului.</param>
        /// <param name="phoneNumber">Numărul de telefon al utilizatorului.</param>
        /// <param name="email">Adresa de email a utilizatorului.</param>
        /// <param name="password">Parola pentru contul utilizatorului.</param>
        public void Register(string firstName, string lastName, string phoneNumber, string email, string password)
        {
            _homePage.GoRegister();

            _registerPage.Register(firstName, lastName, phoneNumber, email, password);

        }
       
        #endregion
    }
}
