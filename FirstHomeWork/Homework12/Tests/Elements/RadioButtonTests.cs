using Homework12.Drivers;
using Homework12.Pages.Elements;
using NUnit.Framework;

namespace Homework12.Tests
{
    public class RadioButtonTests : BaseTest
    {
        [SetUp]
        public void RadioButtonTestsSetUp()
        {
            WebDriverFactory.Driver.Navigate().GoToUrl(TestSettings.RadioButtonPageUrl);
        }

        [Test]
        public void RadioButtonsAreNotSelectedByDefaultTest()
        {
            var radioButtonPage = new RadioButtonPage();
            Assert.IsFalse(radioButtonPage.IsYesRadioChecked());
            Assert.IsFalse(radioButtonPage.IsImpressiveRadioChecked());
            Assert.IsFalse(radioButtonPage.IsNoRadioChecked());
        }

        [Test]
        public void ResultShowsSelectedValueTest()
        {
            var radioButtonPage = new RadioButtonPage();
            radioButtonPage.SelectYes();
            Assert.AreEqual("Yes", radioButtonPage.GetResultText());
            radioButtonPage.SelectImpressive();
            Assert.AreEqual("Impressive", radioButtonPage.GetResultText());
        }
    }
}
