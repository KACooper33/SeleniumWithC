using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectModel.Source.Pages
{
public class LoginPage
{
private IWebDriver _driver;

//***********************************************
// MATCHERS
//***********************************************
[FindsBy(How = How.Name, Using = "username")]
private IWebElement _username;

[FindsBy(How = How.Name, Using = "password")]
private IWebElement _password;

[FindsBy(How = How.Name, Using = "commit")]
private IWebElement _signIn_button;



//***********************************************
// Functions
//***********************************************

public LoginPage(IWebDriver driver) 
{
_driver = driver;
PageFactory.InitElements(driver, this);
}

public void Login(string username, string password)
{
    _username.SendKeys(username);
    _password.SendKeys(password);
    _signIn_button.Click();
}


}
}