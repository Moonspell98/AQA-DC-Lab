using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;

namespace Homework10.Tests
{
    public class DynamicPropertiesTests
    {
        IWebDriver _driver;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl("https://demoqa.com/dynamic-properties");
        }

        [Test]
        public void ButtonIsEnabledTest()
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(5));
            var button = wait.Until(drv =>
            {
                var element = _driver.FindElement(By.XPath("//*[@id = 'enableAfter']"));
                if (element.Enabled)
                {
                    return element;
                }
                else
                {
                    return null;
                }
            });
            Assert.True(button.Enabled);
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            _driver.Quit();
        }
    }
}
