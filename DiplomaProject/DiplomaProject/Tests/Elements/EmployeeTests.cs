using DiplomaProject.Common;
using DiplomaProject.Data;
using DiplomaProject.PageObjects.OrangeHRM;
using DiplomaProject.PageObjects.OrangeHRM.Elements.PIM;
using NUnit.Framework;

namespace DiplomaProject.Tests.Elements
{
    public class EmployeeTests : PimBaseTest
    {
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

            CreateRandomUser(out firstName, out middleName, out lastName, out id);  

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

            CreateRandomUser(out firstName, out middleName, out lastName, out id);

            GenericPages.PersonalDetailsPage.NavigateToEmployeeListPage();
            GenericPages.EmployeeListPage.SearchById(id);
            GenericPages.EmployeeListPage.EditEmployeeById(id);

            GenericPages.PersonalDetailsPage.EditFirstName(firstName = RandomHelper.GetRandomString(10));
            GenericPages.PersonalDetailsPage.EditMiddleName(middleName = RandomHelper.GetRandomString(10));
            GenericPages.PersonalDetailsPage.EditLastName(lastName = RandomHelper.GetRandomString(10));
            GenericPages.PersonalDetailsPage.EditId(id = RandomHelper.GetRandomInt(1000, 9999).ToString());
            Thread.Sleep(4000);
            GenericPages.PersonalDetailsPage.SaveEmployee();



        }

        public void CreateRandomUser(out string firstName, out string middleName, out string lastName, out string id)
        {
            firstName = RandomHelper.GetRandomString(10);
            middleName = RandomHelper.GetRandomString(10);
            lastName = RandomHelper.GetRandomString(10);
            id = RandomHelper.GetRandomInt(1000, 9999).ToString();

            GenericPages.AddEmployeePage.EnterFirstName(firstName);
            GenericPages.AddEmployeePage.EnterMiddleName(middleName);
            GenericPages.AddEmployeePage.EnterLastName(lastName);
            GenericPages.AddEmployeePage.EnterEmpoyeeId(id);
            Thread.Sleep(8000);
            GenericPages.AddEmployeePage.SaveEmployee();
        }
    }
}
