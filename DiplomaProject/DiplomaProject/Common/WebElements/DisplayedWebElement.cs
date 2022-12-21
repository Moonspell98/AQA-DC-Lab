using DiplomaProject.Common.Drivers;
using DiplomaProject.Common.Extensions;
using OpenQA.Selenium;

namespace DiplomaProject.Common.WebElements
{
    public class DisplayedWebElement : MyWebElement
    {
        public DisplayedWebElement(By by) : base(by)
        {
        }

        protected new IWebElement WebElement => WebDriverFactory.Driver.GetWebElementWhenDisplayed(By);
    }
}
