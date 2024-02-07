using Microsoft.Extensions.Logging;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWithC.src.PageObjects
{
    public class BasePage
    {
        protected IWebDriver _driver;
        protected ILogger _logger;

        //***********************************************
        // MATCHERS - None should be added to the base page
        //***********************************************




    //***********************************************
    // Functions
    //***********************************************

    public BasePage(IWebDriver driver) 
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

    }
}