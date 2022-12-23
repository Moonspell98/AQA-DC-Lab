using Homework12.Drivers;
using Homework12.Pages.Elements;
using NUnit.Framework;

namespace Homework12.Tests.Elements
{
    public class ButtonsTests : BaseTest
    {
        [SetUp]
        public void ButtonsTestsSetUp()
        {
            WebDriverFactory.Driver.Navigate().GoToUrl(TestSettings.ButtonsPageUrl);
        }

        [Test]
        public void DoubleClickTest()
        {
            var buttonsPage = new ButtonsPage();
            buttonsPage.DoubleClickOnDoubleClickButton();
            Assert.AreEqual("You have done a double click", buttonsPage.GetDoubleClickMessage());
        }

        [Test]
        public void RightClickTest()
        {
            var buttonsPage = new ButtonsPage();
            buttonsPage.RightClickOnRightClickButton();
            Assert.AreEqual("You have done a right click", buttonsPage.GetRightClickMessage());
        }

        [Test]
        public void ClickTest()
        {
            var buttonsPage = new ButtonsPage();
            buttonsPage.ClickOnClickButton();
            Assert.AreEqual("You have done a dynamic click", buttonsPage.GetClickResultMessage());
        }
    }
}
