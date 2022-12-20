using Homework12.Drivers;
using Homework12.Pages.Elements;
using Homework12.Pages.Modals;
using NUnit.Framework;

namespace Homework12.Tests.Elements
{
    public class WebTablesTests : BaseTest
    {
        [SetUp]
        public void WebTablesTestsSetUp()
        {
            WebDriverFactory.Driver.Navigate().GoToUrl(TestSettings.WebTablePageUrl);
        }

        [Test]
        public void AddEntryToTableTest()
        {
            var fname = "John";
            var lname = "Doe";
            var email = "jdoe@email.com";
            var age = "20";
            var salary = "1000";
            var department = "Security";

            var webTablesPage = new WebTablesPage();
            var registrationFormModal = webTablesPage.AddEntry();
            registrationFormModal.EnterFirstName(fname);
            registrationFormModal.EnterLastName(lname);
            registrationFormModal.EnterEmail(email);
            registrationFormModal.EnterAge(age);
            registrationFormModal.EnterSalary(salary);
            registrationFormModal.EnterDepartment(department);
            registrationFormModal.SubmitModal();
            Assert.AreEqual(fname, webTablesPage.GetLastRowCellValue("First Name"));
            Assert.AreEqual(lname, webTablesPage.GetLastRowCellValue("Last Name"));
            Assert.AreEqual(email, webTablesPage.GetLastRowCellValue("Email"));
            Assert.AreEqual(age, webTablesPage.GetLastRowCellValue("Age"));
            Assert.AreEqual(salary, webTablesPage.GetLastRowCellValue("Salary"));
            Assert.AreEqual(department, webTablesPage.GetLastRowCellValue("Department"));
        }
    }
}
