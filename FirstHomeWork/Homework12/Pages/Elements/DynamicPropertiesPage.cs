using Homework12.Common.WebElements;
using Homework12.Drivers;
using Homework12.Extensions;
using Homework12.PageObjects;
using OpenQA.Selenium;

namespace Homework12.Pages.Elements
{
    public class DynamicPropertiesPage : BasePage
    {
        private IWebElement timerEnabledButton = WebDriverFactory.Driver.GetElementWhenEnabled(By.XPath("//*[@id = 'enableAfter']"));

        public bool IsButtonEnabled()
        {
            return timerEnabledButton.Enabled;
        }

    }
}
