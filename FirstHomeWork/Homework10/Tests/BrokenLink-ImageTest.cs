using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Homework10.Tests
{
    public class BrokenLink_ImageTest
    {
        IWebDriver _driver;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl("https://demoqa.com/broken");
        }

        [Test]
        public void ImagesTest()
        {
            var images = _driver.FindElements(By.XPath("//*[@class='row']//img"));
            // naturalWidth of image = 0 means that image is not displayed correctly 
            foreach (var img in images)
            {
                Assert.IsFalse(img.GetAttribute("naturalWidth").Equals("0"));
            }
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            _driver.Quit();
        }
    }
}
