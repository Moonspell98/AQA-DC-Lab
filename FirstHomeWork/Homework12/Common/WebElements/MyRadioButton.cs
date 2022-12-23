using OpenQA.Selenium;

namespace Homework12.Common.WebElements
{
    public class MyRadioButton : MyWebElement
    {
        public IWebElement ButtonLabel => this.FindElement(By.XPath("./following-sibling::label"));

        public bool IsChecked => bool.Parse(WebElement.GetDomProperty("checked"));

        public MyRadioButton(By by) : base(by)
        {
        }

        public void Check()
        {
            if (!IsChecked)
            {
                ButtonLabel.Click();
            }
        }
    }
}
