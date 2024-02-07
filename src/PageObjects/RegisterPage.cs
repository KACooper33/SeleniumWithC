using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWithC.src.PageObjects
{
public class RegisterPage : BasePage
{

    //***********************************************
    // MATCHERS
    //***********************************************
    [FindsBy(How = How.TagName, Using = "h2")]
    private IWebElement _heading;


    //***********************************************
    // Functions
    //***********************************************


    public RegisterPage(IWebDriver driver) : base(driver)
    {
    }

    public bool VerifyHeading(string text)
    {
        var headingMatchesExpectedValue = _heading.Text == text;
        return headingMatchesExpectedValue;
    }


}
}