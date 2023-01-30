using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace DiplomaProject.Common.Extensions
{
    public static class WebDriverExtensions
    {
        public static WebDriverWait GetWebDriverWait(this IWebDriver driver, int timeoutSeconds = 15, TimeSpan? pollingInterval = null, params Type[] exceptionsTypes)
        {
            var webDriverWait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutSeconds));
            if (pollingInterval != null)
            {
                webDriverWait.PollingInterval = (TimeSpan)pollingInterval;
            }
            webDriverWait.IgnoreExceptionTypes(exceptionsTypes);

            return webDriverWait;
        }

        public static IWebElement GetWebElementWhenExist(this IWebDriver driver, By by) => driver.GetWebDriverWait().Until(drv => drv.FindElement(by));

        public static IWebElement GetWebElementWhenEnabled(this IWebDriver driver, By by)
        {
            driver.GetWebDriverWait().Until(drv => drv.FindElement(by).Enabled);

            return driver.FindElement(by);
        }

        public static IWebElement? GetWebElementWhenDisplayed(this IWebDriver driver, By by)
        {
            driver.GetWebDriverWait().Until(drv => drv.FindElement(by).Displayed);

            return driver.FindElement(by);
        }
    }
}
