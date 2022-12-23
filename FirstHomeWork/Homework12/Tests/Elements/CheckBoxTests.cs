using Homework10.Tools;
using Homework12.Drivers;
using Homework12.Pages.Elements;
using NUnit.Framework;

namespace Homework12.Tests.Elements
{
    public class CheckBoxTests : BaseTest
    {
        [SetUp]
        public void CheckBoxTestsSetUp()
        {
            WebDriverFactory.Driver.Navigate().GoToUrl(TestSettings.CheckBoxPageUrl);
        }

        [Test]
        public void GeneralCheckBoxTest()
        {
            var checkBoxPage = new CheckBoxPage();
            checkBoxPage.ExpandAll();
            Assert.AreEqual(6, checkBoxPage.ExpandedChevronsCount());

            checkBoxPage.CheckGeneralCheckBox();
            Assert.AreEqual(checkBoxPage.GetAllElementsTitles().Count(), checkBoxPage.GetAllCheckedElementsTitles().Count());

            foreach (var elementTitle in checkBoxPage.GetAllElementsTitles())
            {
                Assert.IsTrue(checkBoxPage.GetResutlSectionText().ToLower().Contains(TextNormalizer.Normalize(elementTitle.ToLower())));
            }
        }
    }
}
