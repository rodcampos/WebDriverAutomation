using NUnit.Framework;
using NUnit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using WebDriverAutomation.PageObjects;

[TestFixture]
public class Test
{
    private IWebDriver driver;
    private string url;

    [Test]
    public void test1()
    {
        try
        {
        driver.Navigate().GoToUrl(url);
        Home HomePage = new Home(driver);
        Register register = HomePage.ClickLnk_Register(driver);   
        Assert.IsTrue(register.header_Register.Displayed);
        Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
        ss.SaveAsFile("C:/Screenshot.png", ScreenshotImageFormat.Png);
        }
        catch(NoSuchElementException){}
    }

    [SetUp]
    public void Setup()
    {
        driver = new ChromeDriver("./");
        url = "https://www.redmine.org/";
        driver.Manage().Window.Maximize();
    }

    [TearDown]
    public void TearDown()
    {
        driver.Close();
    }

}
