using DiplomaProject.Common.WebElements;
using OpenQA.Selenium;

namespace DiplomaProject.PageObjects.OrangeHRM
{
    public class OrangeHRMBasePage
    {
        private DisplayedWebElement _pageTitle => new DisplayedWebElement(By.XPath("//*[@class='oxd-topbar-header-breadcrumb']"));
        private DisplayedWebElement _searchField => new DisplayedWebElement(By.XPath("//input[@placeholder='Search']"));

        public DisplayedWebElement NavigationItem(string navigaionItemName) => new DisplayedWebElement(By.XPath($"//*[contains(@class, 'main-menu-item')]/*[text()='{navigaionItemName}']"));
    } 
}
