using Homework12.Drivers;
using Homework12.Pages.Elements;
using NUnit.Framework;

namespace Homework12.Tests.Elements
{
    public class LinksTests : BaseTest
    {
        [SetUp]
        public void LinksTestsSetUp()
        {
            WebDriverFactory.Driver.Navigate().GoToUrl(TestSettings.LinksPageUrl);
        }

        [Test]
        public void HomePageNavigateLinkTest()
        {
            var linksPage = new LinksPage();

            var homePage = linksPage.ClickOnHomePageLink();
            WebDriverFactory.Driver.SwitchTo().Window(WebDriverFactory.Driver.WindowHandles.Last());

            Assert.IsTrue(homePage.IsBannerDisplayed());
        }
    }
}
