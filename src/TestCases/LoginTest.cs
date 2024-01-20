namespace SeleniumWithC;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using PageObjectModel.Source.Pages;

[TestClass]
public class LoginTest : BaseTest
{
    
    [TestMethod]
    public void TestLoginOK()
    {
        LoginPage loginPage = new LoginPage(driver);
        loginPage.Login("agileway", "testwise");
        SelectFlightPage selectFlightPage = new SelectFlightPage(driver);
        Assert.IsTrue(selectFlightPage.VerifySignedIn("Signed in!"), "Signed In was not found after completing login");
    }
}