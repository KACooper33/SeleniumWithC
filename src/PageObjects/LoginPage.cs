using Microsoft.Extensions.Logging;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumWithC.src.Drivers.Wrappers;


namespace SeleniumWithC.src.PageObjects
{
    public class LoginPage : BasePage
    {

        //***********************************************
        // MATCHERS
        //***********************************************
        private Element _username => _driver.FindElement(By.Name("username"));
        private Element _password => _driver.FindElement(By.Name("password"));
        private Element _signIn_button => _driver.FindElement(By.Name("commit"));
        private Element _invalidEmailWarning => _driver.FindElement(By.Id("flash_alert"));
        private Element _registerLink => _driver.FindElement(By.LinkText("Register"));


        //***********************************************
        // Functions
        //***********************************************

        public LoginPage(Driver driver) : base(driver)
        {
        }

        public void Login(string username, string password)
        {
            _logger.LogInformation($"Sending keys for Username:{username}");
            _username.TypeText(username);
            _logger.LogDebug($"Sending keys for Password:{password}");
            _password.TypeText(password);
            _logger.LogInformation($"Clicking Sign In Button");
            _signIn_button.Click();
        }
        public void clickSignInButton()
        {
            _logger.LogInformation($"Clicking Sign In Button");
            _signIn_button.Click();
        }


        public void ClickRegisterLink()
        {
            _registerLink.Click();
        }


        public bool VerifyInvalidEmailWorning(string text)
        {
            var warningMatchesExpectedValue = _invalidEmailWarning.Text == text;
            return warningMatchesExpectedValue;
        }

    }
}