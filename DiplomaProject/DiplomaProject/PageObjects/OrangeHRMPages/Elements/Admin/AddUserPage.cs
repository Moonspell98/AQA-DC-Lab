using DiplomaProject.Common.WebElements;
using DiplomaProject.Data;
using DiplomaProject.Data.Constants;
using DiplomaProject.PageObjects.OrangeHRMPages.Elements.Admin;
using OpenQA.Selenium;

namespace DiplomaProject.PageObjects.OrangeHRM.Elements.Admin
{
    public class AddUserPage : AdminBasePage
    {
        private const string ParentFollowingSiblingXpathPart = "/parent::div/following-sibling::div";
        private MyDropDown _userRoleDropDown => new MyDropDown(By.XPath($"//label[text()='{AddUserPageFields.UserRole}']{ParentFollowingSiblingXpathPart}"));
        public MySearchToSelectField _employeeNameTextBox => new MySearchToSelectField(By.XPath($"//label[text()='{AddUserPageFields.EmployeeName}']{ParentFollowingSiblingXpathPart}"));
        private MyDropDown _statusDropDown => new MyDropDown(By.XPath($"//label[text()='{AddUserPageFields.Status}']{ParentFollowingSiblingXpathPart}"));
        private MyWebElement _userNameTextBox => new MyWebElement(By.XPath($"//label[text()='{AddUserPageFields.UserName}']{ParentFollowingSiblingXpathPart}//input"));
        private MyWebElement _passwordTextBox => new MyWebElement(By.XPath($"//label[text()='{AddUserPageFields.Password}']{ParentFollowingSiblingXpathPart}//input"));
        private MyWebElement _confirmPasswordTextBox => new MyWebElement(By.XPath($"//label[text()='{AddUserPageFields.ConfirmPassword}']{ParentFollowingSiblingXpathPart}//input"));
        private MyWebElement _saveButton => new MyWebElement(By.XPath("//button[@type='submit']"));

        public AddUserPage()
        {
            pageUrl = TestSettings.AddUserPageUrl;
        }
        
        public void SelectUserRole(string dropdownOption) => _userRoleDropDown.SelectValueByName(dropdownOption);

        public void SelectEmployeeName(string searchText) => _employeeNameTextBox.SelectItem(searchText);

        public void TypeInEmployeeName(string text) => _employeeNameTextBox.TypeInField(text);

        public void SelectStatus(string dropdownOption) => _statusDropDown.SelectValueByName(dropdownOption);

        public void EnterUserName(string userName)
        {
            _userNameTextBox.Click();
            _userNameTextBox.ClearViaJs();
            _userNameTextBox.SendKeys(userName);
            _userNameTextBox.WaitForElementHaveNoErrors(5);
        }

        public void EnterPassword(string password) => _passwordTextBox.SendKeys(password);

        public void ConfirmPassword(string password) => _confirmPasswordTextBox.SendKeys(password);

        public void ClickOnSaveButton() => _saveButton.Click();
    }
}
