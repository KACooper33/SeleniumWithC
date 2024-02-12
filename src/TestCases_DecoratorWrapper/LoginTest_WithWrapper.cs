using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumWithC.src.PageObjects;
using SeleniumWithC.src.Drivers.Wrappers;

namespace SeleniumWithC.src.TestCases_DecoratorWrapper;

[TestClass]
public class LoginTest_WithWrapper
{
    //public IWebDriver driver = null;
    protected static Driver _driver;    

    [TestInitialize]
    public void Initialize(){
        _driver = new LoggingDriver(new SeleniumWithC.src.Drivers.Wrappers.WebDriver());
        _driver.Start(Browser.Chrome);
        _driver.GoToUrl("http://travel.agileway.net");       
    }

    [TestCleanup]
    public void Cleanup(){
        _driver.Quit();
    }


    [TestMethod]
    public void TestLoginOK()
    {
        Element usernameField = _driver.FindElement(By.Id("username"));
        usernameField.TypeText("agileway");
        Element passwordField = _driver.FindElement(By.Id("password"));
        passwordField.TypeText("testwise");
        Element signInButton = _driver.FindElement(By.Name("commit"));
        signInButton.Click();
        Element flashNotice = _driver.FindElement(By.Id("flash_notice"));
        Assert.IsTrue(flashNotice.Text == "Signed in!", "Signed In was not found after completing login");
        
    }

    // [TestMethod]
    // public void TestLogin_InvalidPassword()
    // {
    //     LoginPage loginPage = new LoginPage(driver);
    //     loginPage.Login("agileway", "incorrect");
    //     loginPage.clickSignInButton();
    //     Assert.IsTrue(loginPage.VerifyInvalidEmailWorning("Invalid email or password"), "Failed to find 'Invalid email or password' warning after entering invalid credentials");
    // }

    // [TestMethod]
    // public void TestLogin_RegisterPage()
    // {
    //     LoginPage loginPage = new LoginPage(driver);
    //     loginPage.ClickRegisterLink();
    //     RegisterPage registerPage = new RegisterPage(driver);
    //     Assert.IsTrue(registerPage.VerifyHeading("Heading New Staff"), "Failed to find 'Heading New Staff' header on the register page");
    // }
}