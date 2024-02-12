using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using SeleniumExtras.WaitHelpers;
using System.Collections.ObjectModel;

namespace SeleniumWithC.src.Drivers.Wrappers;
public class WebDriver : Driver
{
    private IWebDriver _webDriver;
    private WebDriverWait _webDriverWait;

    public override void Start(Browser browser)
    {
        switch (browser)
        {
            case Browser.Chrome:
                _webDriver = new ChromeDriver();
                break;
            case Browser.Firefox:
                _webDriver = new FirefoxDriver();
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(Browser), browser, null);
        }
        _webDriverWait = new WebDriverWait(_webDriver, TimeSpan.FromSeconds(30));
    }

    public override void Quit()
    {
        _webDriver.Quit();
    }

    public override void GoToUrl(string url)
    {
        _webDriver.Navigate().GoToUrl(url);
    }

    public override Element FindElement(By locator)
    {
        IWebElement nativeWebElement = _webDriverWait.Until(ExpectedConditions.ElementExists(locator));
        Element element = new WebElement(_webDriver, nativeWebElement, locator);
        Element logElement = new LogElement(element);

        return logElement;
    }

    public override List<Element> FindElements(By locator)
    {
        ReadOnlyCollection<IWebElement> nativeWebElements = _webDriverWait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(locator));
        var elements = new List<Element>();
        foreach(var nativeWebElement in nativeWebElements)
        {
            Element element = new WebElement(_webDriver, nativeWebElement, locator);
            elements.Add(element);
        }
        return elements;
    }
}