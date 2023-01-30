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
        private MyWebElement AddUserButton => new MyWebElement(By.XPath("//button[contains(normalize-space(), 'Add')]"));
        private MyWebElement UsernameSearchTextBox => new MyWebElement(By.XPath("//label[text()='Username']/parent::div/following-sibling::div//input"));
        private MyWebElement SearchButton => new MyWebElement(By.XPath("//button[@type='submit']"));
        private MyWebElement BulkDeleteButton => new MyWebElement(By.XPath("//button[contains(@class, 'label-danger')]"));
        public MyGrid UsersGrid => new MyGrid(By.XPath("//*[contains(@class, 'employee-list')]"));

        public SystemUsersListPage()
        {
            pageUrl = TestSettings.UserManagementPageUrl;
        }

        public string GetCellTextByUserName(string userName, string columnName)
        {
            var cellValue = UsersGrid.GetCellTextByColumn(SystemUsersGridColumns.UserName, userName, columnName);

            return cellValue;
        }

        public void EnterUserName(string userName) => UsernameSearchTextBox.SendKeys(userName);

        public void ClickOnAddButton() => AddUserButton.Click();

        public void ClickOnSearchButton() => SearchButton.Click();

        public void ClickOnBulkDeleteButton()
        {
            BulkDeleteButton.ScrollToTop();
            BulkDeleteButton.Click();
        }

        public void SearchByUserName(string userName)
        {
            WaitForPageIsOpened();
            EnterUserName(userName);
            ClickOnSearchButton();
        }
    }
}
