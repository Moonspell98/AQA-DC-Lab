using DiplomaProject.Common.WebElements;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomaProject.PageObjects.OrangeHRM.Elements.Admin
{
    public class AddUserPage : OrangeHRMBasePage
    {
        private DisplayedWebElement _userRoleDropDown => new DisplayedWebElement(By.XPath("//label[text()='User Role']/parent::div/following-sibling::div"));

        public void SelectUserRole(string optionName)
        {
            _userRoleDropDown.Click();
            _userRoleDropDown.FindElement(By.XPath($".//*[@role='listbox']//*[contains(text(),'{optionName}')]")).Click();
        }
    }
}
