using Homework12.Drivers;
using Homework12.Pages.Elements;
using NUnit.Framework;

namespace Homework12.Tests.Elements
{
    public class DynamicPropertiesTests : BaseTest
    {
        [SetUp]
        public void DynamicPropertiesTestsSetUp()
        {
            WebDriverFactory.Driver.Navigate().GoToUrl(TestSettings.DynamicPropertiesPageUrl);
        }

        [Test]
        public void ButtonEnabledTest()
        {
            var dynamicPropertiesPage = new DynamicPropertiesPage();

            Assert.IsTrue(dynamicPropertiesPage.IsButtonEnabled());
        }
    }
}
