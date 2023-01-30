using DiplomaProject.Common.WebElements;
using DiplomaProject.Data.Constants;
using OpenQA.Selenium;

namespace DiplomaProject.PageObjects.OrangeHRM.Elements.PIM
{
    public class PersonalDetailsPage : PimBasePage
    {
        private MyWebElement FirstNameTextBox => new MyWebElement(By.XPath("//*[@name='firstName']"));
        private MyWebElement MiddleNameTextBox => new MyWebElement(By.XPath("//*[@name='middleName']"));
        private MyWebElement LastNameTextBox => new MyWebElement(By.XPath("//*[@name='lastName']"));
        private MyWebElement IdTextBox => new MyWebElement(By.XPath($"//*[text()='{PersonalDetailPageFields.EmployeeId}']/ancestor::div/following-sibling::div/input"));
        private MyWebElement SavePersonalDetailsButton => new MyWebElement(By.XPath("//*[contains(@class, 'employee-content')]/div[1]//button[@type='submit']"));

        public string GetFirstName() => FirstNameTextBox.GetDomProperty("_value");
        
        public string GetLastName() => LastNameTextBox.GetDomProperty("_value");

        public string GetMiddleName() => MiddleNameTextBox.GetDomProperty("_value");

        public string GetId() => IdTextBox.GetDomProperty("_value");

        public void EditFirstName(string firstName)
        {
            FirstNameTextBox.Click();
            FirstNameTextBox.ClearViaJs();
            FirstNameTextBox.SendKeys(firstName);
        }

        public void EditMiddleName(string middleName)
        {
            MiddleNameTextBox.Click();
            MiddleNameTextBox.ClearViaJs();
            MiddleNameTextBox.SendKeys(middleName);
        }

        public void EditLastName(string lastName)
        {
            LastNameTextBox.Click();
            LastNameTextBox.ClearViaJs();
            LastNameTextBox.SendKeys(lastName);
        }

        public void EditId(string id)
        {
            IdTextBox.Click();
            IdTextBox.ClearViaJs();
            IdTextBox.SendKeys(id);
        }

        public void SaveEmployee()
        {
            SavePersonalDetailsButton.Click();
        }
    }
}
