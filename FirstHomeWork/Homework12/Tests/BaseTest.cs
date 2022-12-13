using Homework12.Drivers;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Homework12.Tests
{
    public class BaseTest
    {
        IWebDriver _driver;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            _driver = WebDriverFactory.Driver;
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            _driver.Quit();
        }
    }
}
