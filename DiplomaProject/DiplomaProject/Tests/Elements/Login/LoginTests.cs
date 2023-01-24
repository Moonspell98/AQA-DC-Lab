using Allure.Net.Commons;
using DiplomaProject.Common;
using DiplomaProject.Data;
using DiplomaProject.Data.Constants;
using DiplomaProject.PageObjects.OrangeHRM;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;

namespace DiplomaProject.Tests.Elements.Login
{
    [TestFixture]
    [AllureNUnit]
    [AllureSuite("Login functionality")]
    public class LoginTests : BaseTest
    {
        [SetUp]
        public void SetUp()
        {
            _driver.Navigate().GoToUrl(TestSettings.OrangeHrmLogInPageUrl);
        }

        [AllureSubSuite("Login with valid credentials")]
        [AllureSeverity(SeverityLevel.blocker)]
        [AllureTag("Regression")]
        [AllureDescription("Logining in as admin")]
        [Test]
        public void LoginValidCredentials()
        {
            GenericPages.OrangeLoginPage.EnterUserName(TestSettings.UserName);
            GenericPages.OrangeLoginPage.EnterPassword(TestSettings.Password);
            GenericPages.OrangeLoginPage.PressOnLoginButton();

            Assert.AreEqual(PageTitles.DashboardPageTitle, GenericPages.DashboardPage.GetPageTitleText());
        }

        [AllureSubSuite("Login with invalid credentials")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureTag("Regression")]
        [AllureDescription("Logining with wrong password")]
        [Test]
        public void LoginInvalidPassword()
        {
            GenericPages.OrangeLoginPage.EnterUserName(TestSettings.UserName);
            GenericPages.OrangeLoginPage.EnterPassword(RandomHelper.GetRandomString(10));
            GenericPages.OrangeLoginPage.PressOnLoginButton();

            Assert.AreEqual(WarningSectionMessages.InvalidCredentialsMessage, GenericPages.OrangeLoginPage.GetWarningSectionText());
        }

        [AllureSubSuite("Login with invalid credentials")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureTag("Regression")]
        [AllureDescription("Logining with wrong username")]
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
