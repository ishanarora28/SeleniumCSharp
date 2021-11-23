using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumCSharp.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumCSharp
{
    [TestFixture]
    public class ParallelTesting
    {
        IWebDriver driver;
        [Test, Order(0),Category("ish")]
        public void TestMethod1()
        {
            var Driver= new BrowserUtility().Init(driver);
            IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("ishan.arora19@gmail.com");
            Driver.Close();
        }
        [Test,Order(1)]
        public void TestMethod2()
        {
            var Driver = new BrowserUtility().Init(driver);
            IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("ishan.arora19@gmail.com");
            Driver.Close();
        }
        [Test]
        public void TestMethod3()
        {
            var Driver = new BrowserUtility().Init(driver);
            IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("ishan.arora19@gmail.com");
            Driver.Close();
        }
        [Test]
        public void TestMethod4()
        {
            var Driver = new BrowserUtility().Init(driver);
            IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("ishan.arora19@gmail.com");
            Driver.Close();
        }
        [Test]
        public void TestMethod5()
        {
            var Driver = new BrowserUtility().Init(driver);
            IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("ishan.arora19@gmail.com");
            Driver.Close();
        }
        [Test]
        public void TestMethod6()
        {
            var Driver = new BrowserUtility().Init(driver);
            IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("ishan.arora19@gmail.com");
            Driver.Close();
        }
    }
}
