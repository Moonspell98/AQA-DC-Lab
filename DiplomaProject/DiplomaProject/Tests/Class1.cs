using DiplomaProject.Common.Drivers;
using DiplomaProject.Data;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomaProject.Tests
{
    public class Class1
    {
        IWebDriver _driver;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            _driver = WebDriverFactory.Driver;
        }

        [Test]
        public void Test()
        {
            WebDriverFactory.Driver.Navigate().GoToUrl(TestSettings.ButtonsPageUrl);
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            _driver.Quit();
        }
    }
}
