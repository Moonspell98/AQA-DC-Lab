using OpenQA.Selenium;

namespace DiplomaProject.Common.WebElements
{
    public class MyDropDown : MyWebElement
    {
        public MyDropDown(By by) : base(by)
        {
        }

        public void ExpandDropDown()
        {
            var dropdownIcon = FindElement(By.XPath(".//div[@class='oxd-select-text--after']"));
            dropdownIcon.Click();
        }

        public void SelectValueByName(string name)
        {
            ExpandDropDown();
            var dropdownOption = FindElement(By.XPath($".//div[@role='listbox']//*[contains(text(), '{name}')]"));
            dropdownOption.Click();
        }
    }
}
