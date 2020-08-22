using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace SeleniumTestProject
{
    class Test
    {
        [SetUp]
        public void Setup()
        {
            
        }
        [Test]
        public void Search()
        {
            //var chromeoptions = new ChromeOptions();
            //chromeoptions.AddArgument("headless");
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.google.com");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.Name("q")).SendKeys("Testing" + Keys.Enter);
            driver.Quit();
        }
        [TearDown]
        public void CloseBrowser()
        {
        }
    }
}
