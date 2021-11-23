using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using System.Threading;
using SeleniumCSharp.BaseClass;
using OpenQA.Selenium.Support.UI;

namespace SeleniumCSharp
{
    [TestFixture]
    public class Tests:BaseTest
    {
        [SetUp]
        public void Setup()
        {
                   
        }

        [Test, Category("Smoke")]
        public void Test1()
        {            
            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("ishan.arora19@gmail.com");

            //IWebElement createAccountButton = driver.FindElement(By.XPath("//*[@id='u_0_2_uM']"));
            //createAccountButton.Click();
            

            IWebElement dropDown1 = driver.FindElement(By.XPath(".//*[@id='day']"));
            SelectElement element = new SelectElement(dropDown1);
            element.SelectByIndex(5);
            element.SelectByText("Aug");
            element.SelectByValue("AUG");
            Thread.Sleep(10000);
         
            Assert.Pass();
        }

        [Test,Category("Sanity")]
        public void Test2()
        {
            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("ishan.arora19@gmail.com");
            Thread.Sleep(10000);

            Assert.Pass();
        }
    }
}