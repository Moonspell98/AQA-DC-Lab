using System.Collections.ObjectModel;
using System.Drawing;
using DiplomaProject.Common.Drivers;
using DiplomaProject.Common.Extensions;
using OpenQA.Selenium;

namespace DiplomaProject.Common.WebElements
{
    public class MyWebElement : IWebElement
    {
        protected By By { get; set; }

        protected IWebElement WebElement => WebDriverFactory.Driver.GetWebElementWhenExist(By);

        protected static IWebDriver Driver => WebDriverFactory.Driver;

        public string TagName => WebElement.TagName;

        public string Text => WebElement.Text;

        public bool Enabled => WebElement.Enabled;

        public bool Selected => WebElement.Selected;

        public Point Location => WebElement.Location;

        public Size Size => WebElement.Size;

        public bool Displayed => WebElement.Displayed;

        public MyWebElement(By by)
        {
            By = by;
        }

        public void Click()
        {
            try
            {
                WebElement.Click();
            }
            catch (ElementClickInterceptedException)
            {
                ScrollIntoView();
                WebElement.Click();
            }
        }

        public void Clear() => WebElement.Clear();

        public void ClearViaJs() => WebDriverFactory.JavaScriptExecutor.ExecuteScript("arguments[0].value = '';", WebElement);

        public IWebElement FindElement(By by) 
        {
            return Driver.GetWebElementWhenExist(by);
        }

        public bool IsDisplayed(int timeout = 3)
        {
            try
            {
                WaitForElementIsDisplayed(timeout);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool IsEnabled(int timeout = 3)
        {
            try
            {
                WaitForElementIsEnabled(timeout);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public ReadOnlyCollection<IWebElement> FindElements(By by) => WebElement.FindElements(by);

        public string GetAttribute(string attributeName) => WebElement.GetAttribute(attributeName);

        public string GetCssValue(string propertyName) => WebElement.GetCssValue(propertyName);

        public string GetDomAttribute(string attributeName) => WebElement.GetDomAttribute(attributeName);

        public string GetDomProperty(string propertyName) => WebElement.GetDomProperty(propertyName);

        public ISearchContext GetShadowRoot() => WebElement.GetShadowRoot();

        public void SendKeys(string text) => WebElement.SendKeys(text);

        public void Submit() => WebElement.Submit();

        public void ScrollIntoView() => WebDriverFactory.JavaScriptExecutor.ExecuteScript("arguments[0].scrollIntoView()", WebElement);

        public void WaitForElementIsDisplayed(int timeout) => Driver
            .GetWebDriverWait(timeout).Until(drv => WebElement.Displayed);

        public void WaitForElementIsEnabled(int timeout) => Driver
            .GetWebDriverWait(timeout).Until(drv => WebElement.Enabled);

        public void WaitForElementHaveNoErrors(int timeout) => Driver
            .GetWebDriverWait(timeout).Until(drv => !WebElement.GetAttribute("class").Contains("error"));
    }
}
