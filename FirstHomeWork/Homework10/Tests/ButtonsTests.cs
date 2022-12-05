using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;

namespace Homework10.Tests
{
    public class ButtonsTest
    {
        IWebDriver _driver;
        Actions _driverActions;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl("https://demoqa.com/buttons");
            _driverActions = new Actions(_driver);
        }

        // DoubleClick Test
        [Test]
        public void DoubleClickTest()
        {
            var doubleClickButton = _driver.FindElement(By.Id("doubleClickBtn"));
            _driverActions.DoubleClick(doubleClickButton).Perform();

            var doubleClickResult = _driver.FindElement(By.Id("doubleClickMessage"));
            Assert.AreEqual("You have done a double click", doubleClickResult.Text);
        }

        // Right Click test
        [Test]
        public void RightClickTest()
        {
            var rightClickButton = _driver.FindElement(By.Id("rightClickBtn"));
            _driverActions.ContextClick(rightClickButton).Perform();

            var rightClickResult = _driver.FindElement(By.Id("rightClickMessage"));
            Assert.AreEqual("You have done a right click", rightClickResult.Text);

        }

        // Click Test
        [Test]
        public void ClickTest()
        {
            var clickButton = _driver.FindElement(By.XPath("//*[@type ='button'][text() = 'Click Me']"));
            clickButton.Click();

            var clickResult = _driver.FindElement(By.Id("dynamicClickMessage"));
            Assert.AreEqual("You have done a dynamic click", clickResult.Text);
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            _driver.Quit();
        }
    }
}
