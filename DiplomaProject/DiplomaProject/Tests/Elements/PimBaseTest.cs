using DiplomaProject.Common.Drivers;
using DiplomaProject.Data;
using DiplomaProject.PageObjects.OrangeHRM;
using NUnit.Framework;
using OpenQA.Selenium;

namespace DiplomaProject.Tests.Elements
{
    public class PimBaseTest
    {
        public IWebDriver _driver;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            _driver = WebDriverFactory.Driver;
            _driver.Navigate().GoToUrl(TestSettings.OrangeHrmLogInPageUrl);
            GenericPages.OrangeLoginPage.LogInAsAdmin();
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            _driver.Quit();
        }
    }
}
