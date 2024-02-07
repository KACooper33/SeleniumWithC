using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumWithC.src.TestCases_NoBDD;


[TestClass]
public class BaseTest
{
    public IWebDriver driver = null;    

    [TestInitialize]
    public void Initialize(){
        driver = new ChromeDriver();
        driver.Navigate().GoToUrl("http://travel.agileway.net");       
    }

    [TestCleanup]
    public void Cleanup(){
        driver.Quit();
    }
    
}