using DiplomaProject.Common.Drivers;
using DiplomaProject.Common.Extensions;
using DiplomaProject.Common.WebElements;
using OpenQA.Selenium;

namespace DiplomaProject.PageObjects.OrangeHRM
{
    public class OrangeHRMBasePage
    {
        public string pageUrl;
        private MyWebElement _pageTitle => new MyWebElement(By.XPath("//*[@class='oxd-topbar-header-breadcrumb']"));
        private MyWebElement _searchField => new MyWebElement(By.XPath("//input[@placeholder='Search']"));

        public MyWebElement NavigationItem(string navigaionItemName) => new MyWebElement(By.XPath($"//*[contains(@class, 'main-menu-item')]/*[text()='{navigaionItemName}']"));

        public bool WaitForPageIsOpened()
        {
            return WebDriverFactory.Driver.IsPageOpened(pageUrl);
        }

        public OrangeHRMBasePage(string pageUrl)
        {
            this.pageUrl = pageUrl;
        }
    } 
}
