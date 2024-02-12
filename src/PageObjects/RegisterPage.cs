using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumWithC.src.Drivers.Wrappers;

namespace SeleniumWithC.src.PageObjects
{
public class RegisterPage : BasePage
{

    //***********************************************
    // MATCHERS
    //***********************************************
    private Element _heading => _driver.FindElement(By.TagName("h2"));



    //***********************************************
    // Functions
    //***********************************************


    public RegisterPage(Driver driver) : base(driver)
    {
    }

    public bool VerifyHeading(string text)
    {
        var headingMatchesExpectedValue = _heading.Text == text;
        return headingMatchesExpectedValue;
    }


}
}