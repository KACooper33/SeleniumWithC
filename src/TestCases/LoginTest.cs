namespace SeleniumWithC;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using PageObjectModel.Source.Pages;

[TestClass]
public class LoginTest
{
    IWebDriver driver = null;    
    
    [TestMethod]
    public void TestLoginOK()
    {
        driver = new ChromeDriver();
        driver.Navigate().GoToUrl("http://travel.agileway.net");
        LoginPage loginPage = new LoginPage(driver);
        loginPage.Login("agileway", "testwise");
        SelectFlightPage selectFlightPage = new SelectFlightPage(driver);
        Assert.IsTrue(selectFlightPage.VerifySignedIn("Signed in!"), "Signed In was not found after completing login");
        driver.Quit();
    }
}