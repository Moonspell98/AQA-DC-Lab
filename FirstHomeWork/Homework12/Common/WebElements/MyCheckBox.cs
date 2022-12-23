using OpenQA.Selenium;

namespace Homework12.Common.WebElements
{
    public class MyCheckBox : MyWebElement
    {
        public bool Checked => WebElement.GetAttribute("class").Contains("rct-icon-check");

        public MyCheckBox(By by) : base(by)
        {
        }

        public void Check()
        {
            if (!Checked)
            {
                WebElement.Click();
            }
        }

        public void Uncheck()
        {
            if (Checked)
            {
                WebElement.Click();
            }
        }
    }
}
