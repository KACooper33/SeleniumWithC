using OpenQA.Selenium;
namespace SeleniumWithC.src.Drivers.Wrappers;

public abstract class Element
{
    public abstract By by {get;}
    public abstract string Text {get;}
    public abstract bool? Enabled {get;}
    public abstract bool? Displayed {get;}
    public abstract void TypeText(string text);
    public abstract void Click();
    public abstract string GetAttribute(string attributeName);
}