using DiplomaProject.Common.Drivers;
using DiplomaProject.Common.WebElements;
using DiplomaProject.Data;
using OpenQA.Selenium;

namespace DiplomaProject.PageObjects.OrangeHRM.Elements.Admin
{
    public class SystemUsersListPage : OrangeHRMBasePage
    {
        public SystemUsersListPage(string pageUrl) : base(pageUrl)
        {
            base.pageUrl = GenericPages.SystemUsersListPage.currentUrl();
        }

        private MyWebElement _addUserButton => new MyWebElement(By.XPath("//button[contains(normalize-space(), 'Add')]"));
        private MyWebElement _usernameSearchTextBox => new MyWebElement(By.XPath("//label[text()='Username']/parent::div/following-sibling::div//input"));
        private MyWebElement _searchButton => new MyWebElement(By.XPath("//button[@type='submit']"));

        public MyWebElement FindRowById(string id) => new MyWebElement(By.XPath($"//div[text()='{id}']/ancestor::div[@role='row']"));

        public string GetCellTextByUserName(string userName, string columnName)
        {
            var row = FindRowById(userName);
            var cell = row.FindElement(By.XPath($".//div[@class='oxd-table-cell oxd-padding-cell'][count(//*[@role='columnheader'][text()='{columnName}']//preceding-sibling::div) + 1]"));
            return cell.Text;
        }

        public string currentUrl() => WebDriverFactory.Driver.Url;

        public void EnterUserName(string userName) => _usernameSearchTextBox.SendKeys(userName);

        public void ClickOnAddButton() => _addUserButton.Click();

        public void ClickOnSearchButton() => _searchButton.Click();
    }
}
