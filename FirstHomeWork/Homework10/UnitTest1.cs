using Homework10.Tools;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Homework10
{
    public class Tests
    {
        IWebDriver _driver;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();
        }

        [Test]
        public void GeneralCheckBoxTest()
        {
            _driver.Navigate().GoToUrl("https://demoqa.com/checkbox");

            var expandAllButton = _driver.FindElement(By.ClassName("rct-icon-expand-all"));
            expandAllButton.Click();

            var expandedChevrons = _driver.FindElements(By.ClassName("rct-icon-expand-open"));
            Assert.AreEqual(6, expandedChevrons.Count);

            var generalCheckBox = _driver.FindElement(By.ClassName("rct-checkbox"));
            generalCheckBox.Click();

            var allElementsTitles = _driver.FindElements(By.ClassName("rct-title"));
            var allCheckedElements = _driver.FindElements(By.ClassName("rct-icon-check"));
            Assert.AreEqual(allElementsTitles.Count, allCheckedElements.Count);

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