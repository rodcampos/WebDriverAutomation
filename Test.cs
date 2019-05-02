using NUnit.Framework;
using NUnit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using WebDriverAutomation.PageObjects;
using WebDriverAutomation.Helpers;

[TestFixture]
public class Test
{
    private IWebDriver driver;
    private string url;

    [Test]
    public void TestRegister()
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
        catch (NoSuchElementException)
        {
            Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
            ss.SaveAsFile("C:/Screenshot.png", ScreenshotImageFormat.Png);
            Assert.Fail();
        }
    }

    [Test]
    public void TestSignIn()
    {
        try
        {
            driver.Navigate().GoToUrl(url);
            Home HomePage = new Home(driver);
            SignIn SignInPage = HomePage.ClickLnk_SignIn(driver);
            Assert.IsTrue(SignInPage.txt_Login.Displayed);
            Assert.IsTrue(SignInPage.txt_Password.Displayed);
            Assert.IsTrue(SignInPage.btn_Submit.Displayed);
            Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
            ss.SaveAsFile("C:/Screenshot.png", ScreenshotImageFormat.Png);
        }
        catch (NoSuchElementException)
        {
            Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
            ss.SaveAsFile("C:/Screenshot.png", ScreenshotImageFormat.Png);
            Assert.Fail();
        }
    }

    [SetUp]
    public void Setup()
    {
        driver = new DriverHelper().LaunchDriver();
        url = "https://www.redmine.org/";
    }

    [TearDown]
    public void TearDown()
    {
        driver.Close();
    }

}
