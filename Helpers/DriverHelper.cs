using NUnit.Framework;
using NUnit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using WebDriverAutomation.PageObjects;

namespace WebDriverAutomation.Helpers
{
    public class DriverHelper
    {
        private IWebDriver DriverInstance;
        public IWebDriver LaunchDriver()
        {
            DriverInstance = new ChromeDriver("./");
            DriverInstance.Manage().Window.Maximize();
            return DriverInstance;
        }
    }
}