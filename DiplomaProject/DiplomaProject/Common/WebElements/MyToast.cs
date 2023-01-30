using OpenQA.Selenium;

namespace DiplomaProject.Common.WebElements
{
    public class MyToast : MyWebElement
    {
        public MyToast(By by) : base(by)
        {
        }

        public void CloseToast() => WebElement.FindElement(By.XPath(".//*[contains(@class,'toast-close') and @role='button']")).Click();

        public string GetToastTitle() => WebElement.FindElement(By.XPath(".//*[contains(@class,'toast-title')]")).Text;

        public string GetToastMessage()
        {
            WaitForElementIsDisplayed(5);

            return WebElement.FindElement(By.XPath(".//*[contains(@class,'toast-message')]")).Text;
        }
    }
}
