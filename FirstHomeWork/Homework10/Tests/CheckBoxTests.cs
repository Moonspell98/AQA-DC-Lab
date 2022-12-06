using Homework10.Tools;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace Homework10.Tests
{
    public class CheckBoxTests
    {
        IWebDriver _driver;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            _driver.Manage().Window.Maximize();
        }

        // Testing that general checkbox checking selects all the possible checkboxes in tree
        [Test]
        public void GeneralCheckBoxTest()
        {
            _driver.Navigate().GoToUrl("https://demoqa.com/checkbox");

            var expandAllButton = _driver.FindElement(By.ClassName("rct-icon-expand-all"));
            expandAllButton.Click();

            // Checking that after Expand All action, all chevrons (6) are displayed 
            var expandedChevrons = _driver.FindElements(By.ClassName("rct-icon-expand-open"));
            Assert.AreEqual(6, expandedChevrons.Count);

            var generalCheckBox = _driver.FindElement(By.ClassName("rct-checkbox"));
            generalCheckBox.Click();

            // Checking that after clicking on general checkbox, all entries are selected
            var allElementsTitles = _driver.FindElements(By.ClassName("rct-title"));
            var allCheckedElements = _driver.FindElements(By.ClassName("rct-icon-check"));
            Assert.AreEqual(allElementsTitles.Count, allCheckedElements.Count);

            // Checking that all checked elements are displayed in result section
            var resultSection = _driver.FindElement(By.Id("result"));
            //Console.WriteLine(resultSection.Text);
            foreach (var elementTitle in allElementsTitles)
            {
                Assert.That(resultSection.Text.ToLower().Contains(TextNormalizer.Normalize(elementTitle.Text)));
            }
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            _driver.Quit();
        }
    }
}