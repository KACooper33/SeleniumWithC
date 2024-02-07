using OpenQA.Selenium;
using SeleniumWithC.src.Wrappers;
using SeleniumWithC.src.Wrappers.Driver;

public class LoggingDriver : DriverDecorator
{
    public LoggingDriver(Driver driver) : base(driver)
    {

    }
    
    public override void Start(Browser browser)
    {
        Console.WriteLine($"Start browser = {Enum.GetName(typeof(Browser), browser)}");
        Driver?.Start(browser);
    }

    public override void Quit()
    {
        Console.WriteLine($"Close browser");
        Driver?.Quit();
    }

    public override void GoToUrl(string url)
    {
        Console.WriteLine($"Go to url = {url}");
        Driver?.GoToUrl(url);
    }

    public override Element FindElement(By locator)
    {
        Console.WriteLine("Find Element");
        return Driver?.FindElement(locator);
    }

    public override List<Element> FindElements(By locator)
    {
        Console.WriteLine("Find Elements");
        return Driver?.FindElements(locator);
    }
}