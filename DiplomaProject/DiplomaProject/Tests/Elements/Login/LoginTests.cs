using DiplomaProject.Common;
using DiplomaProject.Data;
using DiplomaProject.Data.Constants;
using DiplomaProject.PageObjects.OrangeHRM;
using NUnit.Framework;

namespace DiplomaProject.Tests.Elements.Login
{
    public class LoginTests : BaseTest
    {
        [SetUp]
        public void SetUp()
        {
            _driver.Navigate().GoToUrl(TestSettings.OrangeHrmLogInPageUrl);
        }

        [Test]
        public void LoginValidCredentials()
        {
            GenericPages.OrangeLoginPage.EnterUserName(TestSettings.UserName);
            GenericPages.OrangeLoginPage.EnterPassword(TestSettings.Password);
            GenericPages.OrangeLoginPage.PressOnLoginButton();

            Assert.AreEqual(PageTitles.DashboardPageTitle, GenericPages.DashboardPage.GetPageTitleText());
        }

        [Test]
        public void LoginInvalidPassword()
        {
            GenericPages.OrangeLoginPage.EnterUserName(TestSettings.UserName);
            GenericPages.OrangeLoginPage.EnterPassword(RandomHelper.GetRandomString(10));
            GenericPages.OrangeLoginPage.PressOnLoginButton();

            Assert.AreEqual(WarningSectionMessages.InvalidCredentialsMessage, GenericPages.OrangeLoginPage.GetWarningSectionText());
        }

        [Test]
        public void LoginInvalidUsername()
        {
            GenericPages.OrangeLoginPage.EnterUserName(TestSettings.UserName);
            GenericPages.OrangeLoginPage.EnterPassword(RandomHelper.GetRandomString(10));
            GenericPages.OrangeLoginPage.PressOnLoginButton();

            Assert.AreEqual(WarningSectionMessages.InvalidCredentialsMessage, GenericPages.OrangeLoginPage.GetWarningSectionText());
        }
    }
}
