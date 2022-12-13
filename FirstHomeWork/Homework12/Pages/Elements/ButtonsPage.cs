using Homework12.Common.WebElements;
using Homework12.PageObjects;
using OpenQA.Selenium;

namespace Homework12.Pages.Elements
{
    public class ButtonsPage : BasePage
    {
        private MyWebElement _doubleClickButton = new MyWebElement(By.XPath("//*[@id='doubleClickBtn']"));
        private MyWebElement _rightClickButton = new MyWebElement(By.XPath("//*[@id='rightClickBtn']"));
        private MyWebElement _clickButton = new MyWebElement(By.XPath("//*[@type ='button'][text() = 'Click Me']"));
        private MyWebElement _clickResultMessage = new MyWebElement(By.XPath("//*[@id='dynamicClickMessage']"));
        private MyWebElement _doubleClickResultMessage = new MyWebElement(By.XPath("//*[@id='doubleClickMessage']"));
        private MyWebElement _rightClickResultMessage = new MyWebElement(By.XPath("//*[@id='rightClickMessage']"));

        public void DoubleClickOnDoubleClickButton() => _doubleClickButton.DoubleClick();
        
        public void RightClickOnRightClickButton() => _rightClickButton.RightClick();

        public void ClickOnClickButton() => _clickButton.Click();

        public string GetDoubleClickMessage() => _doubleClickResultMessage.Text;

        public string GetRightClickMessage() => _rightClickResultMessage.Text;

        public string GetClickResultMessage() => _clickResultMessage.Text;
    }
}
