using DiplomaProject.Common.Drivers;
using NUnit.Framework;
using OpenQA.Selenium;

namespace DiplomaProject.Tests
{
    public class BaseTest
    {
        public IWebDriver _driver;

        [OneTimeSetUp]
        public void InitializeDriver()
        {
            _driver = WebDriverFactory.Driver;
        }

        [OneTimeTearDown]
        public void StopDriver()
        {
            _driver.Quit();
        }
    }
}
