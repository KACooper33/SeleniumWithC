using Microsoft.Extensions.Logging;
using OpenQA.Selenium;
namespace SeleniumWithC.src.Drivers.Wrappers;

public class LoggingDriver : DriverDecorator
{
    
    protected ILogger _logger;

    public LoggingDriver(Driver driver) : base(driver)
    {
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
        _logger = loggerFactory.CreateLogger<LoggingDriver>();
    }
    
    public override void Start(Browser browser)
    {
        _logger.LogInformation($"Start browser = {Enum.GetName(typeof(Browser), browser)}");
        Driver?.Start(browser);
    }

    public override void Quit()
    {
        _logger.LogInformation($"Close browser");
        Driver?.Quit();
    }

    public override void GoToUrl(string url)
    {
        _logger.LogInformation($"Go to url = {url}");
        Driver?.GoToUrl(url);
    }

    public override Element FindElement(By locator)
    {
        _logger.LogInformation($"Find Element by locator: {locator}");
        return Driver?.FindElement(locator);
    }

    public override List<Element> FindElements(By locator)
    {
        _logger.LogInformation($"Find Elements by locator: {locator}");
        return Driver?.FindElements(locator);
    }
}