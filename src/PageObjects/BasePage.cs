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
    public class BasePage
    {
        public Driver _driver;
        protected ILogger _logger;


        //***********************************************
        // Functions
        //***********************************************

        public BasePage(Driver driver) 
        {
            _driver = driver;
            //PageFactory.InitElements((IWebDriver)driver, this);

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