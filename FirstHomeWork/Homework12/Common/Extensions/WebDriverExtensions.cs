using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Homework12.Extensions
{
    public static class WebDriverExtensions
    {
        public static WebDriverWait GetWebDriverWait(this IWebDriver driver, int TimeoutSeconds = 10, TimeSpan? pollingInterval = null, params Type[] exceptionTypes)
        {
            var webDriverWait = new WebDriverWait(driver, TimeSpan.FromSeconds(TimeoutSeconds));
            if (pollingInterval != null)
            {
                webDriverWait.PollingInterval = (TimeSpan)pollingInterval;
            }

            webDriverWait.IgnoreExceptionTypes(exceptionTypes);

            return webDriverWait;
        }

        public static IWebElement GetElementWhenExist(this IWebDriver driver, By by) => driver.GetWebDriverWait().Until(drv => drv.FindElement(by));

        public static IWebElement GetElementWhenEnabled(this IWebDriver driver, By by) => driver.GetWebDriverWait().Until(drv =>
        {
            var element = drv.FindElement(by);
            return element.Enabled ? element : null;
        });

        public static IReadOnlyCollection<IWebElement> GetElementsWhenExist(this IWebDriver driver, By by) => driver.GetWebDriverWait().Until(drv => drv.FindElements(by));
    }
}
