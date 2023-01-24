using DiplomaProject.Common.Drivers;
using DiplomaProject.Common.Extensions;
using DiplomaProject.Common.WebElements;
using DiplomaProject.Data;
using DiplomaProject.Data.Constants;
using DiplomaProject.PageObjects.OrangeHRMPages.Elements.Admin;
using OpenQA.Selenium;

namespace DiplomaProject.PageObjects.OrangeHRM.Elements.Admin
{
    public class SystemUsersListPage : AdminBasePage
    {
        private MyWebElement _addUserButton => new MyWebElement(By.XPath("//button[contains(normalize-space(), 'Add')]"));
        private MyWebElement _usernameSearchTextBox => new MyWebElement(By.XPath("//label[text()='Username']/parent::div/following-sibling::div//input"));
        private MyWebElement _searchButton => new MyWebElement(By.XPath("//button[@type='submit']"));
        private MyWebElement _bulkDeleteButton => new MyWebElement(By.XPath("//button[contains(@class, 'label-danger')]"));
        private MyGrid _usersGrid => new MyGrid(By.XPath("//*[contains(@class, 'employee-list')]"));

        public SystemUsersListPage()
        {
            pageUrl = TestSettings.UserManagementPageUrl;
        }

        public string GetCellTextByUserName(string userName, string columnName)
        {
            var cellValue = _usersGrid.GetCellTextByColumn(SystemUsersGridColumns.UserName, userName, columnName);
            return cellValue;
        }

        public void EnterUserName(string userName) => _usernameSearchTextBox.SendKeys(userName);

        public void ClickOnAddButton() => _addUserButton.Click();

        public void ClickOnSearchButton() => _searchButton.Click();

        public void ClickOnBulkDeleteButton()
        {
            _bulkDeleteButton.ScrollToTop();
            _bulkDeleteButton.Click();
        }

        public void EditUserByUsername(string userName) => _usersGrid.EditRow(SystemUsersGridColumns.UserName, userName);

        public void DeleteUserByUsername(string userName) => _usersGrid.DeleteRow(SystemUsersGridColumns.UserName, userName);

        public void SelectUserByUsername(string username) => _usersGrid.SelectRow(SystemUsersGridColumns.UserName, username);


        public void SearchByUserName(string userName)
        {
            WaitForPageIsOpened();
            EnterUserName(userName);
            ClickOnSearchButton();
        }
    }
}
