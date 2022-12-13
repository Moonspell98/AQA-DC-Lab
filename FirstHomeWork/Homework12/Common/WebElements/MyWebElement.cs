using Homework12.Drivers;
using Homework12.Extensions;
using OpenQA.Selenium;
using System.Collections.ObjectModel;
using System.Drawing;

namespace Homework12.Common.WebElements
{
    public class MyWebElement : IWebElement
    {
        protected By By { get; set; }

        protected IWebElement WebElement => WebDriverFactory.Driver.GetElementWhenExist(By);

        public string TagName => WebElement.TagName;

        public string Text => WebElement.Text;

        public bool Enabled => WebElement.Enabled;

        public bool Selected => WebElement.Selected;

        public bool Displayed => WebElement.Displayed;

        public Point Location => WebElement.Location;

        public Size Size => WebElement.Size;

        public MyWebElement(By by)
        {
            By = by;
        }

        public void Clear() => WebElement.Clear();

        public void SendKeys(string text) => WebElement.SendKeys(text);

        public void Submit() => WebElement.Submit();

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

        public void DoubleClick()
        {
            try
            {
                WebDriverFactory.Actions.DoubleClick(WebElement).Perform();
            }
            catch (ElementClickInterceptedException)
            {
                ScrollIntoView();
                WebDriverFactory.Actions.DoubleClick(WebElement).Perform();
            }
        }

        public void RightClick()
        {
            try
            {
                WebDriverFactory.Actions.ContextClick(WebElement).Perform();
            }
            catch (ElementClickInterceptedException)
            {
                ScrollIntoView();
                WebDriverFactory.Actions.ContextClick(WebElement).Perform();
            }
        }

        public string GetAttribute(string attributeName) => WebElement.GetAttribute(attributeName);

        public string GetDomAttribute(string attributeName) => WebElement.GetDomAttribute(attributeName);

        public string GetDomProperty(string propertyName) => WebElement.GetDomProperty(propertyName);

        public string GetCssValue(string propertyName) => WebElement.GetCssValue(propertyName);

        public ISearchContext GetShadowRoot() => WebElement.GetShadowRoot();

        public IWebElement FindElement(By by) => WebElement.FindElement(by);

        public ReadOnlyCollection<IWebElement> FindElements(By by) => WebElement.FindElements(by);

        public void ScrollIntoView() => WebDriverFactory.JavaScriptExecutor.ExecuteScript("arguments[0].scrollIntoView()", WebElement);

        public string GetValueOfClassAtrribute() => GetAttribute("class");

    }
}
