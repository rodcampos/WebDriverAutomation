using NUnit.Framework;
using NUnit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace WebDriverAutomation.PageObjects
{
    public class SignIn
    {
       private IWebDriver driver;
       public SignIn(IWebDriver driver)
       {
           this.driver = driver;
       }

       public IWebElement txt_Login
       {
           get
           {
               return driver.FindElement(By.XPath("//input[@id='username']"));
           }
       }

       public IWebElement txt_Password
       {
           get
           {
               return driver.FindElement(By.XPath("//input[@id='password']"));
           }
       }

       public IWebElement btn_Submit
       {
           get
           {
               return driver.FindElement(By.XPath("//input[@type='submit']"));
           }
       }
    }
}