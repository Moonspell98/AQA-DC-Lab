using DiplomaProject.Common.WebElements;
using OpenQA.Selenium;

namespace DiplomaProject.PageObjects.OrangeHRM.Elements.Admin
{
    public class AddUserPage : OrangeHRMBasePage
    {
        private DisplayedWebElement _userRoleDropDown => new DisplayedWebElement(By.XPath("//label[text()='User Role']/parent::div/following-sibling::div"));
        private DisplayedWebElement _employeeNameTextBox => new DisplayedWebElement(By.XPath("//input[@placeholder='Type for hints...']"));

        public void SelectUserRole(string optionName)
        {
            _userRoleDropDown.Click();
            _userRoleDropDown.FindElement(By.XPath($".//*[@role='listbox']//*[contains(text(),'{optionName}')]")).Click();
        }

        public void EnterAndSelectFirstEmployeeName(string nameToSearch)
        {
            _employeeNameTextBox.SendKeys(nameToSearch);
            _employeeNameTextBox.FindElement(By.XPath(".//following::div[@role='listbox']/div[1]")).Click();
        }
    }
}
