/***************************************************************************
 *                                                                         *
 *  Fisier:      RegisterPage.cs                                           *
 *               Functionalitate adaugata de Cîrja Ioan                    *
 *                                           Mihălucă Mădălina-Maria       *
 *                                           Popa Andrei                   *
 *                                           Sandu Delia-Andreea           *
 * Descriere:   Acest fișier definește clasa RegisterPage, care oferă      *
 *              funcționalități pentru înregistrarea și autentificarea     * 
 *              utilizatorilor pe un site web, incluzând metode și elemente*
 *              web corespunzătoare formularelor de înregistrare și        *
 *              autentificare, utilizând Selenium WebDriver.               *
 *                                                                         *
 *  This code and information is provided "as is" without warranty of      *
 *  any kind, either expressed or implied, including but not limited       *
 *  to the implied warranties of merchantability or fitness for a          *
 *  particular purpose. You are free to use this source code in your       *
 *  applications as long as the original copyright notice is included.     *
 *                                                                         *
 **************************************************************************/


using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;


namespace SiteManipulation
{
    public class RegisterPage
    {
        #region Fields
        /// <summary>
        /// Driver-ul folosit pentru navigare.
        /// </summary>
        private IWebDriver _driver;
        #endregion
        /// <summary>
        /// Constructorul clasei RegisterPage.
        /// </summary>
        /// <param name="browser">Driver-ul de browser folosit pentru navigare.</param>
        #region Methods
        public RegisterPage(IWebDriver browser)
        {
            _driver = browser;
        }

        /// <summary>
        /// Reprezintă câmpul de formular pentru prenume.
        /// </summary>
        public IWebElement FirstNameForm => _driver.FindElement(By.XPath("//*[@id=\"newfirstname\"]"));

        /// <summary>
        /// Reprezintă câmpul de formular pentru nume.
        /// </summary>
        public IWebElement LastNameForm => _driver.FindElement(By.XPath("//*[@id=\"newlastname\"]"));

        /// <summary>
        /// Reprezintă câmpul de formular pentru telefon.
        /// </summary>
        public IWebElement PhoneForm => _driver.FindElement(By.XPath("//*[@id=\"telephone\"]"));

        /// <summary>
        /// Reprezintă câmpul de formular pentru email.
        /// </summary>
        public IWebElement EmailForm => _driver.FindElement(By.XPath("//*[@id=\"newemail\"]"));

        /// <summary>
        /// Reprezintă câmpul de formular pentru parolă.
        /// </summary>
        public IWebElement PasswordForm => _driver.FindElement(By.XPath("//*[@id=\"newpassword\"]"));

        /// <summary>
        /// Reprezintă câmpul de formular pentru reintroducerea parolei.
        /// </summary>
        public IWebElement RepeatPasswordForm => _driver.FindElement(By.XPath("//*[@id=\"newpasswordretype\"]"));

        /// <summary>
        /// Reprezintă câmpul de formular pentru termenii și condițiile.
        /// </summary>
        public IWebElement TermsAndConditionsForm => _driver.FindElement(By.XPath("//*[@id=\"terms_conditions\"]"));

        /// <summary>
        /// Reprezintă câmpul de formular pentru abonarea la newsletter.
        /// </summary>
        public IWebElement NewsletterForm => _driver.FindElement(By.XPath("//*[@id=\"newsletter\"]"));
        /// <summary>
        /// Reprezintă butonul pentru crearea unui cont.
        /// </summary>
        public IWebElement CreateAccountBtn => _driver.FindElement(By.XPath("//*[@id=\"register\"]/fieldset/div/div[9]/button"));



        /// <summary>
        /// Reprezintă câmpul de formular pentru email.
        /// </summary>
        public IWebElement EmailLoginForm => _driver.FindElement(By.XPath("//*[@id=\"email\"]"));
        /// <summary>
        /// Reprezintă câmpul de formular pentru parolă.
        /// </summary>
        public IWebElement PasswordLoginForm => _driver.FindElement(By.XPath("//*[@id=\"password\"]"));
        /// <summary>
        /// Reprezintă butonul pentru logare.
        /// </summary>
        public IWebElement LoginButton => _driver.FindElement(By.XPath("//*[@id=\"login\"]/fieldset/div[1]/div/button"));




        /// <summary>
        /// Metodă care înregistrează un nou utilizator cu detaliile furnizate.
        /// </summary>
        /// <param name="firstName">Prenumele utilizatorului.</param>
        /// <param name="lastName">Numele de familie al utilizatorului.</param>
        /// <param name="phoneNumber">Numărul de telefon al utilizatorului.</param>
        /// <param name="email">Adresa de email a utilizatorului.</param>
        /// <param name="password">Parola pentru contul utilizatorului.</param>
        public void Register(string firstName, string lastName, string phoneNumber, string email, string password)
        {
            Thread.Sleep(3000);

            _driver.Manage().Window.Maximize();

            FirstNameForm.SendKeys(firstName);
            LastNameForm.SendKeys(lastName);
            PhoneForm.SendKeys(phoneNumber);
            EmailForm.SendKeys(email);
            PasswordForm.SendKeys(password);
            RepeatPasswordForm.SendKeys(password);
            TermsAndConditionsForm.Click();
            NewsletterForm.Click();
            Thread.Sleep(1000);

            CreateAccountBtn.Click();
        }
        /// <summary>
        /// Metodă care autentifică un utilizator cu email-ul și parola furnizate.
        /// </summary>
        /// <param name="email">Adresa de email a utilizatorului.</param>
        /// <param name="password">Parola utilizatorului.</param>
        public void Login(string email, string password)
        {

            _driver.Manage().Window.Maximize();

            Thread.Sleep(3000);
            EmailLoginForm.SendKeys(email);
            PasswordLoginForm.SendKeys(password);
            Thread.Sleep(2000);

            LoginButton.Click();

        }
        #endregion
    }
}
