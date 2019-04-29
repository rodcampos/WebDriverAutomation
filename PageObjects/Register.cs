using NUnit.Framework;
using NUnit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace WebDriverAutomation.PageObjects
{
    public class Register
    {
       private IWebDriver driver;
       public Register(IWebDriver driver)
       {
           this.driver = driver;
       }

       public IWebElement header_Register
       {
           get
           {
               return driver.FindElement(By.XPath("//h2[text()='Register ']"));
           }
       }
    }
}