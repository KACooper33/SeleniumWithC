using OpenQA.Selenium;
using SeleniumWithC.src.Wrappers;

public class LogElement : ElementDecorator
{
    public LogElement(Element element)
    :base(element)
    {

    }

    public override By by => Element?.by;

    public override string Text
    {
        get
        {
            Console.WriteLine("Element Text = {Element?.Text}");
            return Element?.Text;
        }
    }

    public override bool? Enabled
    {
        get
        {
            Console.WriteLine("Element Enabled = {Element?.Enabled}");
            return Element?.Enabled;
        }
    }

    public override bool? Displayed
    {
        get
        {
            Console.WriteLine("Element Enabled = {Element?.Displayed}");
            return Element?.Displayed;
        }
    }

    public override void Click()
    {
        Console.WriteLine("Element Clicked");
        Element?.Click();
    }

    public override string GetAttribute(string attributeName)
    {
        Console.WriteLine("Get Element's Attribute = {attributeName}");
        return Element?.GetAttribute(attributeName);
    }

    public override void TypeText(string text)
    {
        Console.WriteLine($"Type Text = {text}");
        Element?.TypeText(text);
    }
}