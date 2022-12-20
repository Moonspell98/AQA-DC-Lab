using Homework12.Drivers;
using Homework12.Pages.Elements;
using NUnit.Framework;

namespace Homework12.Tests.Elements
{
    public class BrokenLinksAndImagesTests : BaseTest
    {
        [SetUp]
        public void BrokenLinksAndImagesTestsSetUp()
        {
            WebDriverFactory.Driver.Navigate().GoToUrl(TestSettings.BrokenLinkAndImagesPageUrl);
        }

        [Test]
        public void ImagesTest()
        {
            var brokenLinksAndImagesPage = new BrokenLinksAndImagesPage();
            Assert.IsFalse(brokenLinksAndImagesPage.IsImagesDisplayed());
        }
    }
}
