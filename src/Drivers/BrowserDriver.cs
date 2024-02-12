using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumWithC.src.Drivers.Wrappers;


namespace SeleniumWithC.src.Drivers
{
    /// <summary>
    /// Manages a browser instance using Selenium
    /// </summary>
    public class BrowserDriver : IDisposable
    {
        private readonly Lazy<Driver> _currentWebDriverLazy;
        private bool _isDisposed;

        public BrowserDriver()
        {
            _currentWebDriverLazy = new Lazy<Driver>(CreateWebDriver);
        }

        /// <summary>
        /// The Selenium IWebDriver instance
        /// </summary>
        public Driver Current => _currentWebDriverLazy.Value;

        /// <summary>
        /// Creates the Selenium web driver (opens a browser)
        /// </summary>
        /// <returns></returns>
        private Driver CreateWebDriver()
        {
            Driver driver = new LoggingDriver(new SeleniumWithC.src.Drivers.Wrappers.WebDriver());
            driver.Start(Browser.Chrome);
            return driver;
        }

        /// <summary>
        /// Disposes the Selenium web driver (closing the browser)
        /// </summary>
        public void Dispose()
        {
            if (_isDisposed)
            {
                return;
            }

            if (_currentWebDriverLazy.IsValueCreated)
            {
                Current.Quit();
            }

            _isDisposed = true;
        }
    }
}