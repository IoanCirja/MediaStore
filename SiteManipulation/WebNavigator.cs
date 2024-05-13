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
        private ChromeDriver _driver;
        private HomePage _homePage;
        private RegisterPage _registerPage;


        public WebNavigator()
        {
            ChromeOptions options = new ChromeOptions();

            var chromeDriverService = ChromeDriverService.CreateDefaultService();
            chromeDriverService.HideCommandPromptWindow = true;

            _driver = new ChromeDriver(chromeDriverService, options);
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl("https://www.itgalaxy.ro/");

           _homePage = new HomePage(_driver);
            _registerPage = new RegisterPage(_driver);

        }

        public void Login(string email, string password)
        {
            _homePage.GoRegister();
            Thread.Sleep(3000);
            _registerPage.Login(email, password);

        }

        public void Register(string firstName, string lastName, string phoneNumber, string email, string password)
        {
            _homePage.GoRegister();

            _registerPage.Register( firstName,  lastName,  phoneNumber, email, password);

        }
    }
}
