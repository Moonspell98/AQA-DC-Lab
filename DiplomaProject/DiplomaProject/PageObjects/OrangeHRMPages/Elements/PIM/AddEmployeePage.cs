using DiplomaProject.Common;
using DiplomaProject.Common.WebElements;
using DiplomaProject.Data;
using DiplomaProject.Data.Constants;
using OpenQA.Selenium;

namespace DiplomaProject.PageObjects.OrangeHRM.Elements.PIM
{
    public class AddEmployeePage : PimBasePage
    {
        private MyWebElement FirstNameTextBox => new MyWebElement(By.XPath("//input[@name='firstName']"));
        private MyWebElement MiddleNameTextBox => new MyWebElement(By.XPath("//input[@name='middleName']"));
        private MyWebElement LastNameTextBox => new MyWebElement(By.XPath("//input[@name='lastName']"));
        private MyWebElement EmployeeIdTextBox => new MyWebElement(By.XPath($"//*[text()='{AddEmployeePageFields.Id}']/ancestor::div/following-sibling::div/input"));
        private MyWebElement SaveButton => new MyWebElement(By.XPath("//button[@type='submit']"));

        public AddEmployeePage()
        {
            pageUrl = TestSettings.AddEmployeePageUrl;
        }

        public void EnterFirstName(string firstName) => FirstNameTextBox.SendKeys(firstName);

        public void EnterLastName(string lastName) => LastNameTextBox.SendKeys(lastName);

        public void EnterMiddleName(string middleName) => MiddleNameTextBox.SendKeys(middleName);

        public void EnterEmpolyeeId(string id)
        {
            // Doing this to avoid field autofilling after clear
            EmployeeIdTextBox.Click();
            EmployeeIdTextBox.ClearViaJs();
            EmployeeIdTextBox.SendKeys(id);
        }

        public void ClickOnSaveButton() => SaveButton.Click();

        public void CreateRandomEmployee(out string firstName, out string middleName, out string lastName, out string id)
        {
            firstName = RandomHelper.GetRandomString(10);
            middleName = RandomHelper.GetRandomString(10);
            lastName = RandomHelper.GetRandomString(10);
            id = RandomHelper.GetRandomInt(1000, 9999).ToString();

            EnterFirstName(firstName);
            EnterMiddleName(middleName);
            EnterLastName(lastName);
            EnterEmpolyeeId(id);
            ClickOnSaveButton();
        }
    }
}
