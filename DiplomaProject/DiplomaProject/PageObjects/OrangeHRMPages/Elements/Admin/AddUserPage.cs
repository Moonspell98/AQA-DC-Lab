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
        private MyDropDown UserRoleDropDown => new MyDropDown(By.XPath($"//label[text()='{AddUserPageFields.UserRole}']{ParentFollowingSiblingXpathPart}"));
        public MySearchToSelectField EmployeeNameTextBox => new MySearchToSelectField(By.XPath($"//label[text()='{AddUserPageFields.EmployeeName}']{ParentFollowingSiblingXpathPart}"));
        private MyDropDown StatusDropDown => new MyDropDown(By.XPath($"//label[text()='{AddUserPageFields.Status}']{ParentFollowingSiblingXpathPart}"));
        private MyWebElement UserNameTextBox => new MyWebElement(By.XPath($"//label[text()='{AddUserPageFields.UserName}']{ParentFollowingSiblingXpathPart}//input"));
        private MyWebElement PasswordTextBox => new MyWebElement(By.XPath($"//label[text()='{AddUserPageFields.Password}']{ParentFollowingSiblingXpathPart}//input"));
        private MyWebElement ConfirmPasswordTextBox => new MyWebElement(By.XPath($"//label[text()='{AddUserPageFields.ConfirmPassword}']{ParentFollowingSiblingXpathPart}//input"));
        private MyWebElement SaveButton => new MyWebElement(By.XPath("//button[@type='submit']"));

        public AddUserPage()
        {
            pageUrl = TestSettings.AddUserPageUrl;
        }
        
        public void SelectUserRole(string dropdownOption) => UserRoleDropDown.SelectValueByName(dropdownOption);

        public void SelectEmployeeName(string searchText) => EmployeeNameTextBox.SelectItem(searchText);

        public void TypeInEmployeeName(string text) => EmployeeNameTextBox.TypeInField(text);

        public void SelectStatus(string dropdownOption) => StatusDropDown.SelectValueByName(dropdownOption);

        public void EnterUserName(string userName)
        {
            UserNameTextBox.Click();
            UserNameTextBox.ClearViaJs();
            UserNameTextBox.SendKeys(userName);
            UserNameTextBox.WaitForElementHaveNoErrors(5);
        }

        public void EnterPassword(string password) => PasswordTextBox.SendKeys(password);

        public void ConfirmPassword(string password) => ConfirmPasswordTextBox.SendKeys(password);

        public void ClickOnSaveButton() => SaveButton.Click();
    }
}
