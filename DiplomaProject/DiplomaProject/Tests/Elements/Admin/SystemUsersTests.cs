using DiplomaProject.Common;
using DiplomaProject.Common.Drivers;
using DiplomaProject.Data;
using DiplomaProject.PageObjects.OrangeHRM;
using DiplomaProject.Tests.Elements.PIM;
using NUnit.Framework;
using OpenQA.Selenium;

namespace DiplomaProject.Tests.Elements.Admin
{
    public class SystemUsersTests : BaseTest
    {
        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            _driver.Navigate().GoToUrl(TestSettings.OrangeHrmLogInPageUrl);
            GenericPages.OrangeLoginPage.LogInAsAdmin();
        }

        [SetUp]
        public void Setup()
        {
            _driver.Navigate().GoToUrl(TestSettings.UserManagementPageUrl);
        }

        [Test]
        public void AddSystemUser()
        {
            string firstName;
            string middleName;
            string lastName;
            string id;
            string userName;

            _driver.Navigate().GoToUrl(TestSettings.AddEmployeePageUrl);
            GenericPages.AddEmployeePage.CreateRandomEmployee(out firstName, out middleName, out lastName, out id);
            AddRandomSystemUser($"{firstName} {middleName} {lastName}", out userName);
            Assert.AreEqual("Successfully Saved", GenericPages.AddUserPage.GetSuccessToastMessage());
        }

        [Test]
        public void SearchSystemUser() 
        {
            string firstName;
            string middleName;
            string lastName;
            string id;
            string userName;

            _driver.Navigate().GoToUrl(TestSettings.AddEmployeePageUrl);
            GenericPages.AddEmployeePage.CreateRandomEmployee(out firstName, out middleName, out lastName, out id);
            AddRandomSystemUser($"{firstName} {middleName} {lastName}", out userName);
            GenericPages.SystemUsersListPage.WaitForPageIsOpened();
            GenericPages.SystemUsersListPage.EnterUserName(userName);
            GenericPages.SystemUsersListPage.ClickOnSearchButton();
        }

        public void AddRandomSystemUser(string employeeName, out string userName)
        {
            var userRole = "Admin";
            var status = "Enabled";
            var password = $"{RandomHelper.GetRandomString(10)}a1;";
            userName = RandomHelper.GetRandomString(10);

            _driver.Navigate().GoToUrl(TestSettings.AddUserPageUrl);
            GenericPages.AddUserPage.SelectUserRole(userRole);
            GenericPages.AddUserPage.SelectEmployeeName(employeeName);
            GenericPages.AddUserPage.SelectStatus(status);
            GenericPages.AddUserPage.EnterUserName(userName);
            GenericPages.AddUserPage.EnterPassword(password);
            GenericPages.AddUserPage.ConfirmPassword(password);
            GenericPages.AddUserPage.ClickOnSaveButton();
        }
    }
}
