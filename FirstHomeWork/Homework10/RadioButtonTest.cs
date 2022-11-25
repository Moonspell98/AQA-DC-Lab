using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Homework10
{
    public class RadioButtonTest
    {
        IWebDriver _driver;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl("https://demoqa.com/radio-button");
        }

        // Checking that no one radio button item is not preselected
        [Test]
        public void RadioButtonsIsNotSelectedTest()
        {
            var yesRadio = _driver.FindElement(By.Id("yesRadio"));
            var impressedRadio = _driver.FindElement(By.Id("impressiveRadio"));
            var noRadio = _driver.FindElement(By.Id("noRadio"));
            Assert.Multiple(() =>
            {
                Assert.IsFalse(yesRadio.GetDomProperty("checked").Equals(true));
                Assert.IsFalse(impressedRadio.GetDomProperty("checked").Equals(true));
                Assert.IsFalse(noRadio.GetDomProperty("checked").Equals(true));
            });

        }

        // Checking that result section displayes selected value
        [Test]
        public void ResultShowsSelectedValueTest()
        {
            var yesRadioClickableLabel = _driver.FindElement(By.XPath("//*[@for = 'yesRadio']"));
            var impressedRadioClickableLabel = _driver.FindElement(By.XPath("//*[@for = 'impressiveRadio']"));

            yesRadioClickableLabel.Click();
            var resultTextBox = _driver.FindElement(By.ClassName("text-success"));
            Assert.AreEqual("Yes", resultTextBox.Text);

            impressedRadioClickableLabel.Click();
            Assert.AreEqual("Impressive", resultTextBox.Text);
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            _driver.Quit();
        }
    }
}
