using DiplomaProject.Common.Drivers;
using DiplomaProject.Common.Extensions;
using DiplomaProject.Common.WebElements;
using DiplomaProject.Data;
using OpenQA.Selenium;

namespace DiplomaProject.PageObjects.OrangeHRM
{
    public class OrangeHRMBasePage
    {
        public string? pageUrl;
        private MyWebElement _pageTitle => new MyWebElement(By.XPath("//*[@class='oxd-topbar-header-breadcrumb']"));
        private MyWebElement _searchField => new MyWebElement(By.XPath("//input[@placeholder='Search']"));
        private MyToast _successToast => new MyToast(By.XPath("//*[contains(@class,'toast--success')]"));
        private MyToast _infoToast => new MyToast(By.XPath("//*[contains(@class,'toast--info')]"));

        public MyWebElement NavigationItem(string navigaionItemName) => new MyWebElement(By.XPath($"//*[contains(@class, 'main-menu-item')]/*[text()='{navigaionItemName}']"));
        
        public void ClickOnNavigationItem(string navigationItemName) => NavigationItem(navigationItemName).Click();

        public void WaitForPageIsOpened()
        {
            WebDriverFactory.Driver.GetWebDriverWait().Until(drv => drv.Url == pageUrl);
        }

        public string GetInfoToastMessage() => _infoToast.GetToastMessage();

        public string GetSuccessToastMessage() => _successToast.GetToastMessage();

        public string GetPageTitleText() => _pageTitle.Text;    
    } 
}
