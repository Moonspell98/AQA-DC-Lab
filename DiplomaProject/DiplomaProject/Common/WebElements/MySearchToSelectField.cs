using DiplomaProject.Common.Extensions;
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
            var searchTextBox = FindElement(By.XPath(".//input"));
            searchTextBox.SendKeys(text);
        }

        public void SelectItem(string text, string itemName)
        {
            TypeInField(text);
            var searchOption = FindElement(By.XPath($".//div[@role='listbox']//*[contains(text(), '{itemName}')]"));
            searchOption.Click();
        }
    }
}
