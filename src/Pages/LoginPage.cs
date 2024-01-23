using Microsoft.Extensions.Logging;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectModel.Source.Pages
{
    public class LoginPage : BasePage
    {

        //***********************************************
        // MATCHERS
        //***********************************************
        [FindsBy(How = How.Name, Using = "username")]
        private IWebElement _username;

        [FindsBy(How = How.Name, Using = "password")]
        private IWebElement _password;

        [FindsBy(How = How.Name, Using = "commit")]
        private IWebElement _signIn_button;

        [FindsBy(How = How.Id, Using = "flash_alert")]
        private IWebElement _invalidEmailWarning;

        [FindsBy(How = How.LinkText, Using = "Register")]
        private IWebElement _registerLink;


    //***********************************************
    // Functions
    //***********************************************

    public LoginPage(IWebDriver driver) : base(driver)
    {
    }

    public void Login(string username, string password)
    {
        _logger.LogInformation($"Sending keys for Username:{username}");
        _username.SendKeys(username);
        _logger.LogDebug($"Sending keys for Password:{password}");
        _password.SendKeys(password);
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