using Allure.Net.Commons;
using DiplomaProject.Common.Drivers;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
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

        [TearDown]
        public void TearDown()
        {
            if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
            {
                var screenShot = ((ITakesScreenshot)_driver).GetScreenshot().AsByteArray;
                AllureLifecycle.Instance.AddAttachment(TestContext.CurrentContext.Test.Name, "image/png", screenShot);
            }
        }

        [OneTimeTearDown]
        public void StopDriver()
        {
            _driver.Quit();
        }
    }
}
