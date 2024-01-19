using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectModel.Source.Pages
{
public class SelectFlightPage
{
private IWebDriver _driver;

//***********************************************
// MATCHERS
//***********************************************
[FindsBy(How = How.Id, Using = "flash_notice")]
private IWebElement _signedInNotice;

// [FindsBy(How = How.c, Using = "password")]
// private IWebElement signedInText;

// [FindsBy(How = How.Name, Using = "commit")]
// private IWebElement _signIn_button;



//***********************************************
// Functions
//***********************************************

public SelectFlightPage(IWebDriver driver) 
{
_driver = driver;
PageFactory.InitElements(driver, this);
}

public bool VerifySignedIn(string text)
{
    var noticeMatchesExpectedValue = _signedInNotice.Text == text;
    return noticeMatchesExpectedValue;
}


}
}