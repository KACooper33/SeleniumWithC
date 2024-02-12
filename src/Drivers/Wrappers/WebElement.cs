using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras;
using SeleniumExtras.WaitHelpers;
namespace SeleniumWithC.src.Drivers.Wrappers;
public class WebElement : Element
{
    private readonly IWebDriver _webDriver;
    private readonly IWebElement _webElement;
    private readonly By _by;

    public WebElement(IWebDriver webDriver, IWebElement webElement, By by)
    {
        _webDriver = webDriver; 
        _webElement = webElement;
        _by = by;
    }

    public override By by => _by;
    public override string Text => _webElement.Text;
    public override bool? Enabled => _webElement.Enabled;
    public override bool? Displayed => _webElement.Displayed;
    public override void Click()
    {
        WaitToBeClickable(by);
        _webElement?.Click();
    }

    public override string GetAttribute(string attributeName)
    {
        return _webElement.GetAttribute(attributeName);
    }

    public override void TypeText(string text)
    {
        _webElement?.Clear();
        _webElement?.SendKeys(text);
    }

    private void WaitToBeClickable(By by)
    {
        var webDriverWait = new WebDriverWait(_webDriver, TimeSpan.FromSeconds(10));
        webDriverWait.Until(ExpectedConditions.ElementToBeClickable(by));
    }
}