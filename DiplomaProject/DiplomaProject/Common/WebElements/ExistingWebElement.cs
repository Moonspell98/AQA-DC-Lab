using DiplomaProject.Common.Drivers;
using DiplomaProject.Common.Extensions;
using OpenQA.Selenium;

namespace DiplomaProject.Common.WebElements
{
    public class ExistingWebElement : MyWebElement
    {
        public ExistingWebElement(By by) : base(by)
        {
        }

        protected new IWebElement WebElement => WebDriverFactory.Driver.GetWebElementWhenExist(By);
    }
}
