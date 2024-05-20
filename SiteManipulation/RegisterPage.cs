﻿using OpenQA.Selenium;
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
        private IWebDriver _driver;


        public RegisterPage(IWebDriver browser)
        {
            _driver = browser;
        }


        public IWebElement FirstNameForm => _driver.FindElement(By.XPath("//*[@id=\"newfirstname\"]"));
        public IWebElement LastNameForm => _driver.FindElement(By.XPath("//*[@id=\"newlastname\"]"));
        public IWebElement PhoneForm => _driver.FindElement(By.XPath("//*[@id=\"telephone\"]"));
        public IWebElement EmailForm => _driver.FindElement(By.XPath("//*[@id=\"newemail\"]"));
        public IWebElement PasswordForm => _driver.FindElement(By.XPath("//*[@id=\"newpassword\"]"));
        public IWebElement RepeatPasswordForm => _driver.FindElement(By.XPath("//*[@id=\"newpasswordretype\"]"));
        public IWebElement TermsAndConditionsForm => _driver.FindElement(By.XPath("//*[@id=\"terms_conditions\"]"));
        public IWebElement NewsletterForm => _driver.FindElement(By.XPath("//*[@id=\"newsletter\"]"));

        public IWebElement CreateAccountBtn => _driver.FindElement(By.XPath("//*[@id=\"register\"]/fieldset/div/div[9]/button"));




        public IWebElement EmailLoginForm => _driver.FindElement(By.XPath("//*[@id=\"email\"]"));
        public IWebElement PasswordLoginForm => _driver.FindElement(By.XPath("//*[@id=\"password\"]"));
        public IWebElement LoginButton => _driver.FindElement(By.XPath("//*[@id=\"login\"]/fieldset/div[1]/div/button"));

        


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

        public void Login(string email, string password)
        {

            _driver.Manage().Window.Maximize();

            Thread.Sleep(3000);
            EmailLoginForm.SendKeys(email);
            PasswordLoginForm.SendKeys(password);
            Thread.Sleep(2000);

            LoginButton.Click();

        }

    }
}
