using Homework12.Drivers;
using Homework12.Pages.Elements;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            Assert.IsFalse(radioButtonPage.GetYesCheckedProperty().Equals("true"));
            Assert.IsFalse(radioButtonPage.GetNoCheckedProperty().Equals("true"));
            Assert.IsFalse(radioButtonPage.GetImpressiveCheckedProperty().Equals("true"));
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
