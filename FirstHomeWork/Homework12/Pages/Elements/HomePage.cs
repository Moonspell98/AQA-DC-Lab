
using Homework12.Common.WebElements;
using Homework12.PageObjects;
using OpenQA.Selenium;

namespace Homework12.Pages.Elements
{
    public class HomePage : BasePage
    {
        private MyWebElement _pageBanner = new MyWebElement(By.XPath("//*[@alt='Selenium Online Training']"));

        public bool IsBannerDisplayed() => _pageBanner.Displayed;
    }
}
