using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumTestProject
{
    class Test
    {
        IWebDriver driver = new ChromeDriver();
        [SetUp]
        public void Setup()
        {
            driver.Navigate().GoToUrl("https://www.google.com");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }
        [Test]
        public void Search()
        {
            driver.FindElement(By.Name("q")).SendKeys("Testing" + Keys.Enter);

        }
        [TearDown]
        public void CloseBrowser()
        {
            driver.Quit();
        }
    }
}
