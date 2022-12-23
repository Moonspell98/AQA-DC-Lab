using System.Collections;
using Homework12.Drivers;
using Homework12.Extensions;
using OpenQA.Selenium;

namespace Homework12.Common.WebElements
{
    public class MyWebElements : IReadOnlyCollection<IWebElement>
    {
        protected By By { get; set; }

        protected IReadOnlyCollection<IWebElement> WebElements => WebDriverFactory.Driver.GetElementsWhenExist(By);

        public int Count => WebElements.Count();

        public MyWebElements(By by)
        {
            By = by;
        }

        public IEnumerator<IWebElement> GetEnumerator() => WebElements.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => WebElements.GetEnumerator();
    }
}
