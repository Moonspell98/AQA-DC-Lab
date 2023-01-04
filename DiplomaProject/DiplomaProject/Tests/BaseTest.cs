using DiplomaProject.Common.Drivers;
using NUnit.Framework;
using OpenQA.Selenium;

namespace DiplomaProject.Tests
{
    public class BaseTest
    {
        public IWebDriver _driver;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            _driver = WebDriverFactory.Driver;
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            _driver.Quit();
        }
    }
}
