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
    public class LoginPage
    {
        private IWebDriver _driver;
        private ILogger _logger;

        //***********************************************
        // MATCHERS
        //***********************************************
        [FindsBy(How = How.Name, Using = "username")]
        private IWebElement _username;

        [FindsBy(How = How.Name, Using = "password")]
        private IWebElement _password;

        [FindsBy(How = How.Name, Using = "commit")]
        private IWebElement _signIn_button;



    //***********************************************
    // Functions
    //***********************************************

    public LoginPage(IWebDriver driver) 
    {
        _driver = driver;
        PageFactory.InitElements(driver, this);

        // create a logger factory
        var loggerFactory = LoggerFactory.Create(
            builder => builder
                // add console as logging target
                .AddConsole()
                // add debug output as logging target
                .AddDebug()
                // set minimum level to log
                .SetMinimumLevel(Microsoft.Extensions.Logging.LogLevel.Debug)
        );
        _logger = loggerFactory.CreateLogger<LoginPage>();
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


    }
}