using DiplomaProject.Common;
using DiplomaProject.Data;
using DiplomaProject.Data.Constants;
using DiplomaProject.Data.Enums;
using DiplomaProject.PageObjects.OrangeHRM;
using NUnit.Allure.Core;
using NUnit.Framework;

namespace DiplomaProject.Tests.Elements.Admin
{
    [TestFixture]
    [AllureNUnit]
    public class SystemUsersTests : BaseTest
    {
        private string firstName;
        private string middleName;
        private string lastName;
        private string userName;
        private List<string> userNames = new List<string>();

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            _driver.Navigate().GoToUrl(TestSettings.OrangeHrmLogInPageUrl);
            GenericPages.OrangeLoginPage.LogInAsAdmin();
        }

        [Test]
        public void AddSystemUser()
        {
            _driver.Navigate().GoToUrl(TestSettings.AddEmployeePageUrl);
            GenericPages.AddEmployeePage.CreateRandomEmployee(out firstName, out middleName, out lastName, out string id);
            GenericPages.AddEmployeePage.ClickOnNavigationItem(LeftNavigationTitles.Admin);
            AddRandomSystemUser($"{firstName} {middleName} {lastName}", out userName);

            Assert.AreEqual(ToastMessages.SuccessSave, GenericPages.AddUserPage.GetSuccessToastMessage());
        }

        [Test]
        public void SearchSystemUser() 
        {
            _driver.Navigate().GoToUrl(TestSettings.AddEmployeePageUrl);
            GenericPages.AddEmployeePage.CreateRandomEmployee(out firstName, out middleName, out lastName, out string id);
            GenericPages.AddEmployeePage.ClickOnNavigationItem(LeftNavigationTitles.Admin);
            AddRandomSystemUser($"{firstName} {middleName} {lastName}", out userName);
            GenericPages.SystemUsersListPage.SearchByUserName(userName);

            Assert.AreEqual(UserRoles.Admin.ToString(), GenericPages.SystemUsersListPage.GetCellTextByUserName(userName, SystemUsersGridColumns.UserRole));
            Assert.AreEqual($"{firstName} {lastName}", GenericPages.SystemUsersListPage.GetCellTextByUserName(userName, SystemUsersGridColumns.EmployeeName));
            Assert.AreEqual(UserStatuses.Enabled.ToString(), GenericPages.SystemUsersListPage.GetCellTextByUserName(userName, SystemUsersGridColumns.Status));
        }

        [Test]
        public void EditSystemUser()
        {
            _driver.Navigate().GoToUrl(TestSettings.AddEmployeePageUrl);
            GenericPages.AddEmployeePage.CreateRandomEmployee(out firstName, out middleName, out lastName, out string id);
            GenericPages.AddEmployeePage.ClickOnNavigationItem(LeftNavigationTitles.Admin);
            AddRandomSystemUser($"{firstName} {middleName} {lastName}", out userName);
            GenericPages.SystemUsersListPage.SearchByUserName(userName);
            GenericPages.SystemUsersListPage.EditUserByUsername(userName);
            GenericPages.AddUserPage.SelectUserRole(UserRoles.ESS.ToString());
            GenericPages.AddUserPage.SelectStatus(UserStatuses.Disabled.ToString());
            GenericPages.AddUserPage.EnterUserName(userName = RandomHelper.GetRandomString(10));
            GenericPages.AddUserPage.ClickOnSaveButton();
            GenericPages.SystemUsersListPage.SearchByUserName(userName);

            Assert.AreEqual(UserRoles.ESS.ToString(), GenericPages.SystemUsersListPage.GetCellTextByUserName(userName, SystemUsersGridColumns.UserRole));
            Assert.AreEqual($"{firstName} {lastName}", GenericPages.SystemUsersListPage.GetCellTextByUserName(userName, SystemUsersGridColumns.EmployeeName));
            Assert.AreEqual(UserStatuses.Disabled.ToString(), GenericPages.SystemUsersListPage.GetCellTextByUserName(userName, SystemUsersGridColumns.Status));
        }

        [Test]
        public void DeleteSystemUser()
        {
            _driver.Navigate().GoToUrl(TestSettings.AddEmployeePageUrl);
            GenericPages.AddEmployeePage.CreateRandomEmployee(out firstName, out middleName, out lastName, out string id);
            GenericPages.AddEmployeePage.ClickOnNavigationItem(LeftNavigationTitles.Admin);
            AddRandomSystemUser($"{firstName} {middleName} {lastName}", out userName);
            GenericPages.SystemUsersListPage.SearchByUserName(userName);
            GenericPages.SystemUsersListPage.DeleteUserByUsername(userName);
            GenericPages.DeleteModal.AcceptDelete();
            var deleteResultMessage = GenericPages.SystemUsersListPage.GetSuccessToastMessage();
            Assert.AreEqual(ToastMessages.SuccessDelete, deleteResultMessage);
            var searchResultMessage = GenericPages.SystemUsersListPage.GetInfoToastMessage();
            Assert.AreEqual(ToastMessages.InfoNoRecords, searchResultMessage);
        }

        [Test]
        public void BulkDeleteSystemUsers()
        {
            while (userNames.Count < 3)
            {
                _driver.Navigate().GoToUrl(TestSettings.AddEmployeePageUrl);
                GenericPages.AddEmployeePage.CreateRandomEmployee(out firstName, out middleName, out lastName, out string id);
                GenericPages.AddEmployeePage.ClickOnNavigationItem(LeftNavigationTitles.Admin);
                AddRandomSystemUser($"{firstName} {middleName} {lastName}", out userName);
                GenericPages.SystemUsersListPage.WaitForPageIsOpened();
                Console.WriteLine(userName);
                userNames.Add(userName);
            }

            foreach (var user in userNames)
            {
                GenericPages.SystemUsersListPage.SelectUserByUsername(user);
            }

            GenericPages.SystemUsersListPage.ClickOnBulkDeleteButton();
            GenericPages.DeleteModal.AcceptDelete();
            var deleteResultMessage = GenericPages.SystemUsersListPage.GetSuccessToastMessage();

            Assert.AreEqual(ToastMessages.SuccessDelete, deleteResultMessage);
        }

        public void AddRandomSystemUser(string employeeName, out string userName)
        {
            var userRole = UserRoles.Admin.ToString();
            var status = UserStatuses.Enabled.ToString();
            var password = $"{RandomHelper.GetRandomString(10)}a1;";
            userName = $"1{RandomHelper.GetRandomString(10)}";

            GenericPages.SystemUsersListPage.ClickOnAddButton();
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
