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
public class SelectFlightPage : BasePage
{

    //***********************************************
    // MATCHERS
    //***********************************************
    private Element _signedInNotice => _driver.FindElement(By.Id("flash_notice"));


    //***********************************************
    // Functions
    //***********************************************


    public SelectFlightPage(Driver driver) : base(driver)
    {
    }

    public bool VerifySignedIn(string text)
    {
        var noticeMatchesExpectedValue = _signedInNotice.Text == text;
        return noticeMatchesExpectedValue;
    }


}
}