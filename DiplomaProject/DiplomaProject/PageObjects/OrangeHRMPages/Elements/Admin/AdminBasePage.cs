using DiplomaProject.Common.WebElements;
using DiplomaProject.PageObjects.OrangeHRM;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomaProject.PageObjects.OrangeHRMPages.Elements.Admin
{
    public class AdminBasePage : OrangeHRMBasePage
    {
        private MyWebElement _userManagementNavigationButton => new MyWebElement(By.XPath("//*[contains(@class, 'nav-tab') and contains(text(), 'User Management')]"));

        public void NavigateOnUsersListPage()
        {
            _userManagementNavigationButton.Click();
            var usersListPageLink = new MyWebElement(By.XPath("//*[contains(@class, 'dropdown-menu')]//*[@role='menuitem' and text() = 'Users']"));
            usersListPageLink.Click();
        }
    }
}
