using DiplomaProject.Common.WebElements;
using OpenQA.Selenium;

namespace DiplomaProject.PageObjects.OrangeHRM.Elements.PIM
{
    public class PersonalDetailsPage : PimBasePage
    {
        private MyWebElement _firstNameTextBox => new MyWebElement(By.XPath("//*[@name='firstName']"));
        private MyWebElement _middleNameTextBox => new MyWebElement(By.XPath("//*[@name='middleName']"));
        private MyWebElement _lastNameTextBox => new MyWebElement(By.XPath("//*[@name='lastName']"));
        private MyWebElement _idTextBox => new MyWebElement(By.XPath("//*[text()='Employee Id']/ancestor::div/following-sibling::div/input"));
        private MyWebElement _savePersonalDetailsButton => new MyWebElement(By.XPath("//*[contains(@class, 'employee-content')]/div[1]//button[@type='submit']"));

        public string GetFirstName() => _firstNameTextBox.GetDomProperty("_value");
        
        public string GetLastName() => _lastNameTextBox.GetDomProperty("_value");

        public string GetMiddleName() => _middleNameTextBox.GetDomProperty("_value");

        public string GetId() => _idTextBox.GetDomProperty("_value");

        public void EditFirstName(string firstName)
        {
            if (_firstNameTextBox.Enabled)
            {
                _firstNameTextBox.Clear();
                _firstNameTextBox.SendKeys(firstName);
            }
        }

        public void EditMiddleName(string middleName)
        {
            _middleNameTextBox.ClearViaJs();
            _middleNameTextBox.SendKeys("");
            _middleNameTextBox.ClearViaJs();
            _middleNameTextBox.SendKeys(middleName);
        }

        public void EditLastName(string lastName)
        {
            _lastNameTextBox.ClearViaJs();
            _lastNameTextBox.SendKeys("");
            _lastNameTextBox.ClearViaJs();
            _lastNameTextBox.SendKeys(lastName);
        }

        public void EditId(string id)
        {
            _idTextBox.ClearViaJs();
            _idTextBox.SendKeys(" ");
            _idTextBox.ClearViaJs();
            _idTextBox.SendKeys(id);
        }

        public void SaveEmployee()
        {
            _savePersonalDetailsButton.Click();
        }
    }
}
