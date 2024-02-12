using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumWithC.src.Drivers.Wrappers;

namespace SeleniumWithC.src.TestCases_NoBDD;


[TestClass]
public class BaseTest
{
    public Driver driver = null;    

    [TestInitialize]
    public void Initialize(){
        driver = new LoggingDriver(new SeleniumWithC.src.Drivers.Wrappers.WebDriver());
        driver.Start(Browser.Chrome);
        driver.GoToUrl("http://travel.agileway.net");       
    }

    [TestCleanup]
    public void Cleanup(){
        driver.Quit();
    }
    
}