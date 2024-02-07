using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumWithC.src.PageObjects;

namespace SeleniumWithC.src.TestCases_NoBDD;

[TestClass]
public class LoginTest : BaseTest
{
    
    [TestMethod]
    public void TestLoginOK()
    {
        LoginPage loginPage = new LoginPage(driver);
        loginPage.Login("agileway", "testwise");
        loginPage.clickSignInButton();
        SelectFlightPage selectFlightPage = new SelectFlightPage(driver);
        Assert.IsTrue(selectFlightPage.VerifySignedIn("Signed in!"), "Signed In was not found after completing login");
    }

    [TestMethod]
    public void TestLogin_InvalidPassword()
    {
        LoginPage loginPage = new LoginPage(driver);
        loginPage.Login("agileway", "incorrect");
        loginPage.clickSignInButton();
        Assert.IsTrue(loginPage.VerifyInvalidEmailWorning("Invalid email or password"), "Failed to find 'Invalid email or password' warning after entering invalid credentials");
    }

    [TestMethod]
    public void TestLogin_RegisterPage()
    {
        LoginPage loginPage = new LoginPage(driver);
        loginPage.ClickRegisterLink();
        RegisterPage registerPage = new RegisterPage(driver);
        Assert.IsTrue(registerPage.VerifyHeading("Heading New Staff"), "Failed to find 'Heading New Staff' header on the register page");
    }
}