using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V118.Browser;
using SeleniumWithC.src.Wrappers;

namespace SeleniumWithC.src.Wrappers.Driver;


public abstract class Driver
{
    public abstract void Start(Browser browser);
    public abstract void Quit();
    public abstract void GoToUrl(string url);
    public abstract Element FindElement(By Locator);
    public abstract List<Element> FindElements(By Locator);

}

public enum Browser
{
    NotSet,
    Chrome,
    Firefox, 
}

