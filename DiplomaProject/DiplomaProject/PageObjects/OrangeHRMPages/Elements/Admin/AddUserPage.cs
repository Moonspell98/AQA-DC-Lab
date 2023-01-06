using DiplomaProject.Common.Drivers;
using DiplomaProject.Common.Extensions;
using DiplomaProject.Common.WebElements;
using OpenQA.Selenium;

namespace DiplomaProject.PageObjects.OrangeHRM.Elements.Admin
{
    public class AddUserPage : OrangeHRMBasePage
    {
        private MyDropDown _userRoleDropDown => new MyDropDown(By.XPath("//label[text()='User Role']/parent::div/following-sibling::div"));
        public MySearchToSelectField _employeeNameTextBox => new MySearchToSelectField(By.XPath("//label[text()='Employee Name']/parent::div/following-sibling::div"));
        private MyDropDown _statusDropDown => new MyDropDown(By.XPath("//label[text()='Status']/parent::div/following-sibling::div"));
        private MyWebElement _userNameTextBox => new MyWebElement(By.XPath("//label[text()='Username']/parent::div/following-sibling::div//input"));
        private MyWebElement _passwordTextBox => new MyWebElement(By.XPath("//label[text()='Password']/parent::div/following-sibling::div//input"));
        private MyWebElement _confirmPasswordTextBox => new MyWebElement(By.XPath("//label[text()='Confirm Password']/parent::div/following-sibling::div//input"));
        private MyWebElement _saveButton => new MyWebElement(By.XPath("//button[@type='submit']"));
        private MyToast _successToast => new MyToast(By.XPath("//*[contains(@class,'toast--success')]"));
        
        public void SelectUserRole(string dropdownOption) => _userRoleDropDown.SelectValueByName(dropdownOption);

        public void SelectEmployeeName(string searchText) => _employeeNameTextBox.SelectItem(searchText);

        public void TypeInEmployeeName(string text) => _employeeNameTextBox.TypeInField(text);

        public void SelectStatus(string dropdownOption) => _statusDropDown.SelectValueByName(dropdownOption);

        public void EnterUserName(string userName)
        {
            _userNameTextBox.SendKeys(userName);
            _userNameTextBox.WaitForElementHaveNoErrors(5);
        }

        public void EnterPassword(string password) => _passwordTextBox.SendKeys(password);

        public void ConfirmPassword(string password) => _confirmPasswordTextBox.SendKeys(password);

        public void ClickOnSaveButton() => _saveButton.Click();

        public string GetSuccessToastMessage() => _successToast.GetToastMessage();
    }
}
