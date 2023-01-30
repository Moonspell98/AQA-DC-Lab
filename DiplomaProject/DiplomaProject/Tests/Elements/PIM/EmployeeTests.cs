using DiplomaProject.Common;
using DiplomaProject.Data;
using DiplomaProject.Data.Constants;
using DiplomaProject.PageObjects.OrangeHRM;
using NUnit.Framework;

namespace DiplomaProject.Tests.Elements.PIM
{
    public class EmployeeTests : BaseTest
    {
        string firstName;
        string middleName;
        string lastName;
        string id;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            _driver.Navigate().GoToUrl(TestSettings.OrangeHrmLogInPageUrl);
            GenericPages.OrangeLoginPage.LogInAsAdmin();
        }

        [SetUp]
        public void Setup()
        {
            GenericPages.OrangeHrmBasePage.ClickOnNavigationItem(LeftNavigationTitles.Pim);
        }

        [Test]
        public void CreateEmployeeTest()
        {
            GenericPages.EmployeeListPage.ClickOnAddEmployeeButton();

            GenericPages.AddEmployeePage.CreateRandomEmployee(out firstName, out middleName, out lastName, out id);

            Assert.AreEqual(firstName, GenericPages.PersonalDetailsPage.GetFirstName());
            Assert.AreEqual(lastName, GenericPages.PersonalDetailsPage.GetLastName());
            Assert.AreEqual(middleName, GenericPages.PersonalDetailsPage.GetMiddleName());
            Assert.AreEqual(id, GenericPages.PersonalDetailsPage.GetId());

            GenericPages.PersonalDetailsPage.NavigateToEmployeeListPage();
            GenericPages.EmployeeListPage.SearchById(id);

            var actualFirstAndMidlleName = GenericPages.EmployeeListPage.EmployeesGrid.GetCellTextByColumn(EmployeeListPageColumns.Id, id, EmployeeListPageColumns.FirstAndMiddleName);
            var actualLastName = GenericPages.EmployeeListPage.EmployeesGrid.GetCellTextByColumn(EmployeeListPageColumns.Id, id, EmployeeListPageColumns.LastName);
            Assert.AreEqual($"{firstName} {middleName}", actualFirstAndMidlleName);
            Assert.AreEqual(lastName, actualLastName);
        }

        [Test]
        public void EditEmployeeTest()
        {
            GenericPages.EmployeeListPage.ClickOnAddEmployeeButton();

            GenericPages.AddEmployeePage.CreateRandomEmployee(out firstName, out middleName, out lastName, out id);

            GenericPages.PersonalDetailsPage.NavigateToEmployeeListPage();
            GenericPages.EmployeeListPage.SearchById(id);
            GenericPages.EmployeeListPage.EmployeesGrid.EditRow(EmployeeListPageColumns.Id, id);

            GenericPages.PersonalDetailsPage.EditFirstName(firstName = RandomHelper.GetRandomString(10));
            GenericPages.PersonalDetailsPage.EditMiddleName(middleName = RandomHelper.GetRandomString(10));
            GenericPages.PersonalDetailsPage.EditLastName(lastName = RandomHelper.GetRandomString(10));
            GenericPages.PersonalDetailsPage.EditId(id = RandomHelper.GetRandomInt(1000, 9999).ToString());
            GenericPages.PersonalDetailsPage.SaveEmployee();
            GenericPages.PersonalDetailsPage.NavigateToEmployeeListPage();

            GenericPages.EmployeeListPage.SearchById(id);

            var actualFirstAndMidlleName = GenericPages.EmployeeListPage.EmployeesGrid.GetCellTextByColumn(EmployeeListPageColumns.Id, id, EmployeeListPageColumns.FirstAndMiddleName);
            var actualLastName = GenericPages.EmployeeListPage.EmployeesGrid.GetCellTextByColumn(EmployeeListPageColumns.Id, id, EmployeeListPageColumns.LastName);
            Assert.AreEqual($"{firstName} {middleName}", actualFirstAndMidlleName);
            Assert.AreEqual(lastName, actualLastName);
        }

        [Test]
        public void DeleteEmployeeTest()
        {
            GenericPages.EmployeeListPage.ClickOnAddEmployeeButton();

            GenericPages.AddEmployeePage.CreateRandomEmployee(out firstName, out middleName, out lastName, out id);

            GenericPages.PersonalDetailsPage.NavigateToEmployeeListPage();
            GenericPages.EmployeeListPage.SearchById(id);
            GenericPages.EmployeeListPage.EmployeesGrid.DeleteRow(EmployeeListPageColumns.Id, id);
            GenericPages.DeleteModal.AcceptDelete();
            var deleteResultMessage = GenericPages.EmployeeListPage.GetSuccessToastMessage();
            Assert.AreEqual(ToastMessages.SuccessDelete, deleteResultMessage);
            var searchResultMessage = GenericPages.EmployeeListPage.GetInfoToastMessage();
            Assert.AreEqual(ToastMessages.InfoNoRecords, searchResultMessage);
        }
    }
}
