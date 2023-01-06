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
            _firstNameTextBox.Click();
            _firstNameTextBox.ClearViaJs();
            _firstNameTextBox.SendKeys(firstName);
        }

        public void EditMiddleName(string middleName)
        {
            _middleNameTextBox.Click();
            _middleNameTextBox.ClearViaJs();
            _middleNameTextBox.SendKeys(middleName);
        }

        public void EditLastName(string lastName)
        {
            _lastNameTextBox.Click();
            _lastNameTextBox.ClearViaJs();
            _lastNameTextBox.SendKeys(lastName);
        }

        public void EditId(string id)
        {
            _idTextBox.Click();
            _idTextBox.ClearViaJs();
            _idTextBox.SendKeys(id);
        }

        public void SaveEmployee()
        {
            _savePersonalDetailsButton.Click();
        }
    }
}
