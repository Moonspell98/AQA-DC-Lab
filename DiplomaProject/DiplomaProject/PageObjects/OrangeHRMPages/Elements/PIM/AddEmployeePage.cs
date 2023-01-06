using DiplomaProject.Common;
using DiplomaProject.Common.WebElements;
using OpenQA.Selenium;

namespace DiplomaProject.PageObjects.OrangeHRM.Elements.PIM
{
    public class AddEmployeePage : PimBasePage
    {
        private MyWebElement _firstNameTextBox => new MyWebElement(By.XPath("//input[@name='firstName']"));
        private MyWebElement _middleNameTextBox => new MyWebElement(By.XPath("//input[@name='middleName']"));
        private MyWebElement _lastNameTextBox => new MyWebElement(By.XPath("//input[@name='lastName']"));
        private MyWebElement _employeeIdTextBox => new MyWebElement(By.XPath("//*[text()='Employee Id']/ancestor::div/following-sibling::div/input"));
        private MyWebElement _saveButton => new MyWebElement(By.XPath("//button[@type='submit']"));

        public void EnterFirstName(string firstName) => _firstNameTextBox.SendKeys(firstName);

        public void EnterLastName(string lastName) => _lastNameTextBox.SendKeys(lastName);

        public void EnterMiddleName(string middleName) => _middleNameTextBox.SendKeys(middleName);

        public void EnterEmpoyeeId(string id)
        {
            // Doing this to avoid field autofilling after clear
            _employeeIdTextBox.Click();
            _employeeIdTextBox.ClearViaJs();
            _employeeIdTextBox.SendKeys(id);
        }

        public void ClickOnSaveButton() => _saveButton.Click();

        public void CreateRandomEmployee(out string firstName, out string middleName, out string lastName, out string id)
        {
            firstName = RandomHelper.GetRandomString(10);
            middleName = RandomHelper.GetRandomString(10);
            lastName = RandomHelper.GetRandomString(10);
            id = RandomHelper.GetRandomInt(1000, 9999).ToString();

            EnterFirstName(firstName);
            EnterMiddleName(middleName);
            EnterLastName(lastName);
            EnterEmpoyeeId(id);
            ClickOnSaveButton();
        }
    }
}
