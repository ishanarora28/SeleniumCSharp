using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumCSharp.BaseClass
{
   public class BaseTest
    {
        public IWebDriver driver;
        [SetUp]
        public void Open()
        {
            driver = new ChromeDriver("C:\\Users\\IshanArora\\source\repos\\SeleniumCSharp\\SeleniumCSharp");
            driver.Url = "https://www.facebook.com/";
            driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void Close()
        {
            driver.Quit();
        }
        
    }
}
