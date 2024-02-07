using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWithC.src.PageObjects
{
public class SelectFlightPage : BasePage
{

    //***********************************************
    // MATCHERS
    //***********************************************
    [FindsBy(How = How.Id, Using = "flash_notice")]
    private IWebElement _signedInNotice;


    //***********************************************
    // Functions
    //***********************************************


    public SelectFlightPage(IWebDriver driver) : base(driver)
    {
    }

    public bool VerifySignedIn(string text)
    {
        var noticeMatchesExpectedValue = _signedInNotice.Text == text;
        return noticeMatchesExpectedValue;
    }


}
}