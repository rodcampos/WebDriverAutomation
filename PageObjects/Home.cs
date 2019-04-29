using NUnit.Framework;
using NUnit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace WebDriverAutomation.PageObjects
{
    public class Home
    {
       private IWebDriver driver;
       public Home(IWebDriver driver)
       {
           this.driver = driver;
       }

       public IWebElement lnk_Register
       {
           get
           {
               return driver.FindElement(By.XPath("//a[@class='register']"));
           }
       }
    
       public Register ClickLnk_Register(IWebDriver driver)
       {
           lnk_Register.Click();
           return new Register(driver);
       }
    }
}