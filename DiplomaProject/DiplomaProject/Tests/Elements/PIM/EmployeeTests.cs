using DiplomaProject.Common;
using DiplomaProject.Data;
using DiplomaProject.PageObjects.OrangeHRM;
using DiplomaProject.PageObjects.OrangeHRM.Elements.PIM;
using NUnit.Framework;

namespace DiplomaProject.Tests.Elements.PIM
{
    public class EmployeeTests : BaseTest
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
            _driver.Navigate().GoToUrl(TestSettings.EmployeeListPageUrl);
        }

        [Test]
        public void CreateEmployeeTest()
        {
            string firstName;
            string middleName;
            string lastName;
            string id;

            GenericPages.EmployeeListPage.ClickOnAddEmployeeButton();

            GenericPages.AddEmployeePage.CreateRandomEmployee(out firstName, out middleName, out lastName, out id);

            Assert.AreEqual(firstName, GenericPages.PersonalDetailsPage.GetFirstName());
            Assert.AreEqual(lastName, GenericPages.PersonalDetailsPage.GetLastName());
            Assert.AreEqual(middleName, GenericPages.PersonalDetailsPage.GetMiddleName());
            Assert.AreEqual(id, GenericPages.PersonalDetailsPage.GetId());

            GenericPages.PersonalDetailsPage.NavigateToEmployeeListPage();
            GenericPages.EmployeeListPage.SearchById(id);

            Assert.AreEqual($"{firstName} {middleName}", GenericPages.EmployeeListPage.GetCellTextById(id, "First (& Middle) Name"));
            Assert.AreEqual(lastName, GenericPages.EmployeeListPage.GetCellTextById(id, "Last Name"));
        }

        [Test]
        public void EditEmployeeTest()
        {
            string firstName;
            string middleName;
            string lastName;
            string id;

            GenericPages.EmployeeListPage.ClickOnAddEmployeeButton();

            GenericPages.AddEmployeePage.CreateRandomEmployee(out firstName, out middleName, out lastName, out id);

            GenericPages.PersonalDetailsPage.NavigateToEmployeeListPage();
            GenericPages.EmployeeListPage.SearchById(id);
            GenericPages.EmployeeListPage.EditEmployeeById(id);

            GenericPages.PersonalDetailsPage.EditFirstName(firstName = RandomHelper.GetRandomString(10));
            GenericPages.PersonalDetailsPage.EditMiddleName(middleName = RandomHelper.GetRandomString(10));
            GenericPages.PersonalDetailsPage.EditLastName(lastName = RandomHelper.GetRandomString(10));
            GenericPages.PersonalDetailsPage.EditId(id = RandomHelper.GetRandomInt(1000, 9999).ToString());
            GenericPages.PersonalDetailsPage.SaveEmployee();
            GenericPages.PersonalDetailsPage.NavigateToEmployeeListPage();

            GenericPages.EmployeeListPage.SearchById(id);

            Assert.AreEqual($"{firstName} {middleName}", GenericPages.EmployeeListPage.GetCellTextById(id, "First (& Middle) Name"));
            Assert.AreEqual(lastName, GenericPages.EmployeeListPage.GetCellTextById(id, "Last Name"));
        }

        [Test]
        public void DeleteEmployeeTest()
        {
            string firstName;
            string middleName;
            string lastName;
            string id;

            GenericPages.EmployeeListPage.ClickOnAddEmployeeButton();

            GenericPages.AddEmployeePage.CreateRandomEmployee(out firstName, out middleName, out lastName, out id);

            GenericPages.PersonalDetailsPage.NavigateToEmployeeListPage();
            GenericPages.EmployeeListPage.SearchById(id);
            GenericPages.EmployeeListPage.DeleteEmployeeById(id);
            GenericPages.DeleteEmployeeModal.AcceptDelete();
            var deleteResultMessage = GenericPages.EmployeeListPage.GetSuccessToastMessage();
            Assert.AreEqual("Successfully Deleted", deleteResultMessage);
            var searchResultMessage = GenericPages.EmployeeListPage.GetInfoToastMessage();
            Assert.AreEqual("No Records Found", searchResultMessage);
        }
    }
}
