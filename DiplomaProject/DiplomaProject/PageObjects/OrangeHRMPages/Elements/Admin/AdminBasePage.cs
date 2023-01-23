using DiplomaProject.Common.WebElements;
using DiplomaProject.PageObjects.OrangeHRM;
using OpenQA.Selenium;

namespace DiplomaProject.PageObjects.OrangeHRMPages.Elements.Admin
{
    public class AdminBasePage : OrangeHRMBasePage
    {
        private MyWebElement UserManagementNavigationButton => new MyWebElement(By.XPath("//*[contains(@class, 'nav-tab') and contains(text(), 'User Management')]"));

        public void NavigateOnUsersListPage()
        {
            UserManagementNavigationButton.Click();
            var usersListPageLink = new MyWebElement(By.XPath("//*[contains(@class, 'dropdown-menu')]//*[@role='menuitem' and text() = 'Users']"));
            usersListPageLink.Click();
        }
    }
}
