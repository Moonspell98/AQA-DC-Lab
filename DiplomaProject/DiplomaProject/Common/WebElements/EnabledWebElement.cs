using DiplomaProject.Common.Drivers;
using DiplomaProject.Common.Extensions;
using OpenQA.Selenium;

namespace DiplomaProject.Common.WebElements
{
    public class EnabledWebElement : MyWebElement
    {
        public EnabledWebElement(By by) : base(by)
        {
        }

        protected new IWebElement WebElement => WebDriverFactory.Driver.GetWebElementWhenEnabled(By);
    }
}
