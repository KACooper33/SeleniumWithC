using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumWithC.src.Drivers;
using SeleniumWithC.src.PageObjects;

namespace SeleniumWithC.Specs.StepDefinitions
{
    [Binding]
    public class LoginSteps{
        private IWebDriver _driver = null;    

        
        public LoginSteps(BrowserDriver browserDriver){
            _driver = browserDriver.Current;
        }

        [Given(@"I navigate to the login pages")]
        public void GivenINavigateToTheLoginPages(){
            _driver.Navigate().GoToUrl("http://travel.agileway.net");  
        }

        [When(@"I enter a username (.*) and password (.*)")]
        public void WhenIEnterAUsernamdAndPassword(string username, string password){
            LoginPage loginPage = new LoginPage(_driver);
            loginPage.Login(username, password);
        }

        [When(@"I enter a valid username and password")]
        public void WhenIEnterValidUsernamdAndPassword(){
            LoginPage loginPage = new LoginPage(_driver);
            loginPage.Login("agileway", "testwise");
        }

        [When(@"I click the sign in button")]
         public void WhenIClickTheSignInButton(){
            LoginPage loginPage = new LoginPage(_driver);
            loginPage.clickSignInButton();

        }

        [Then(@"I should be redirected to the home page")]
        public void ThenIShouldBeRedirectedToTheHomePage(){
            SelectFlightPage selectFlightPage = new SelectFlightPage(_driver);
            Assert.IsTrue(selectFlightPage.VerifySignedIn("Signed in!"), "Signed In was not found after completing login");
        }        
    }
}
