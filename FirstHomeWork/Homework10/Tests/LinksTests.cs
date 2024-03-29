﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;

namespace Homework10.Tests
{
    public class LinksTests
    {
        IWebDriver _driver;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl("https://demoqa.com/links");
        }

        [Test]
        public void HomePageNavigateLinkTest()
        {
            var homePageLink = _driver.FindElement(By.Id("simpleLink"));
            homePageLink.Click();
            _driver.SwitchTo().Window(_driver.WindowHandles.Last());

            var homePageBanner = _driver.FindElement(By.XPath("//*[@alt='Selenium Online Training']"));
            Assert.IsTrue(homePageBanner.Displayed);
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            _driver.Quit();
        }
    }
}
