using System.Collections.Concurrent;
using DiplomaProject.Data;
using DiplomaProject.Data.Enums;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;

namespace DiplomaProject.Common.Drivers
{
    public class WebDriverFactory
    {
        public static readonly ConcurrentDictionary<string, IWebDriver> DriverCollection = new();

        public static IWebDriver Driver
        {
            get
            {
                if (!DriverCollection.Keys.Contains(TestContextValues.ExecutableClassName))
                {
                    InitializeDriver();
                }

                return DriverCollection.First(pair => pair.Key == TestContextValues.ExecutableClassName).Value;
            }

            private set => DriverCollection.TryAdd(TestContextValues.ExecutableClassName, value);
        }

        public static Actions Actions => new Actions(Driver);

        public static IJavaScriptExecutor JavaScriptExecutor => (IJavaScriptExecutor)Driver;

        public static void QuitDriver() => Driver.Quit();

        private static void InitializeDriver()
        {
            Driver = TestSettings.Browser switch
            {
                Browsers.Chrome => new ChromeDriver(),
                Browsers.Edge => new EdgeDriver(),
                Browsers.FireFox => new FirefoxDriver(),
                _ => throw new InvalidOperationException(),
            };

            Driver.Manage().Window.Maximize();
        }
    }
}
