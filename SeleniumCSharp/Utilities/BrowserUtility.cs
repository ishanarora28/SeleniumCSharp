using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumCSharp.Utilities
{
    public class BrowserUtility
    {

        public IWebDriver Init(IWebDriver driver)

        {
            driver = new ChromeDriver(@"C:\Users\IshanArora\source\repos\SeleniumCSharp\SeleniumCSharp\bin\Debug");
            driver.Url = "https://www.facebook.com/";
            driver.Manage().Window.Maximize();
            return driver;

        }
    }
}
