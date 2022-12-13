using Homework12.Common.WebElements;
using OpenQA.Selenium;

namespace Homework12.PageObjects
{
    public class BasePage
    {
        IWebElement PageTitleElement => new MyWebElement(By.XPath("//*[@class='main-header']"));

        public void ExpandCategory(string categoryName)
        {
            var elementGroupXpathLocator = $"//*[@class='element-group' and .//text()='{categoryName}']";
            var elementListWithCollapseClass = new MyWebElement(By.XPath($"{elementGroupXpathLocator}//div[contains(@class, 'collapse')]"));
            var groupHeader = new MyWebElement(By.XPath($"{elementGroupXpathLocator}//*[@class='group-header']"));

            if (!elementListWithCollapseClass.GetValueOfClassAtrribute().Contains("show"))
            {
                groupHeader.Click();
            }
        }
    }
}
