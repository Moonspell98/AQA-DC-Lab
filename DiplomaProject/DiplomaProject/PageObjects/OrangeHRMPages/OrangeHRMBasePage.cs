using DiplomaProject.Common.Drivers;
using DiplomaProject.Common.Extensions;
using DiplomaProject.Common.WebElements;
using OpenQA.Selenium;

namespace DiplomaProject.PageObjects.OrangeHRM
{
    public class OrangeHRMBasePage
    {
        public string? pageUrl;
        private MyWebElement PageTitle => new MyWebElement(By.XPath("//*[@class='oxd-topbar-header-breadcrumb']"));
        private MyWebElement SearchField => new MyWebElement(By.XPath("//input[@placeholder='Search']"));
        private MyToast SuccessToast => new MyToast(By.XPath("//*[contains(@class,'toast--success')]"));
        private MyToast InfoToast => new MyToast(By.XPath("//*[contains(@class,'toast--info')]"));

        public MyWebElement NavigationItem(string navigaionItemName) => new MyWebElement(By.XPath($"//*[contains(@class, 'main-menu-item')]/*[text()='{navigaionItemName}']"));
        
        public void ClickOnNavigationItem(string navigationItemName) => NavigationItem(navigationItemName).Click();

        public void WaitForPageIsOpened()
        {
            WebDriverFactory.Driver.GetWebDriverWait().Until(drv => drv.Url == pageUrl);
        }

        public string GetInfoToastMessage() => InfoToast.GetToastMessage();

        public string GetSuccessToastMessage() => SuccessToast.GetToastMessage();

        public string GetPageTitleText() => PageTitle.Text;    
    } 
}
