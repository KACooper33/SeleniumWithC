using Microsoft.Extensions.Logging;
using OpenQA.Selenium;
namespace SeleniumWithC.src.Drivers.Wrappers;
public class LogElement : ElementDecorator
{
    protected ILogger _logger;

    public LogElement(Element element)
    :base(element)
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
        _logger = loggerFactory.CreateLogger<LogElement>();

    }

    public override By by => Element?.by;

    public override string Text
    {
        get
        {
            _logger.LogInformation($"Element Text = {Element?.Text}");
            return Element?.Text;
        }
    }

    public override bool? Enabled
    {
        get
        {
            _logger.LogInformation($"Element Enabled = {Element?.Enabled}");
            return Element?.Enabled;
        }
    }

    public override bool? Displayed
    {
        get
        {
            _logger.LogInformation($"Element Enabled = {Element?.Displayed}");
            return Element?.Displayed;
        }
    }

    public override void Click()
    {
        _logger.LogInformation("Element Clicked");
        Element?.Click();
    }

    public override string GetAttribute(string attributeName)
    {
        _logger.LogInformation($"Get Element's Attribute = {attributeName}");
        return Element?.GetAttribute(attributeName);
    }

    public override void TypeText(string text)
    {
        _logger.LogInformation($"Type Text = {text}");
        Element?.TypeText(text);
    }
}