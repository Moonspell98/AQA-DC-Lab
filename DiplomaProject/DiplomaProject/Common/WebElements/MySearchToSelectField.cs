using OpenQA.Selenium;

namespace DiplomaProject.Common.WebElements
{
    public class MySearchToSelectField : MyWebElement
    {
        public MySearchToSelectField(By by) : base(by)
        {
        }

        public void TypeInField(string text)
        {
            var searchTextBox = WebElement.FindElement(By.XPath(".//input"));
            searchTextBox.SendKeys(text);
        }

        public void SelectItem(string text)
        {
            TypeInField(text);
            var searchOption = FindElement(By.XPath($".//div[@role='listbox']//*[contains(text(), '{text}')]"));
            searchOption.Click();
        }
    }
}