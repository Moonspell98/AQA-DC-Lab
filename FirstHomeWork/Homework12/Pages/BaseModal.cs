using Homework12.Common.WebElements;
using OpenQA.Selenium;


namespace Homework12.Pages
{
    public class BaseModal
    {
        private IWebElement _modalTitle = new MyWebElement(By.XPath("//*[contains(@class, 'modal-title')]"));
        private IWebElement _closeModalButton = new MyWebElement(By.XPath("//*[@class='close']"));
        private IWebElement _submitModalButton = new MyWebElement(By.XPath("//*[@id='submit']"));

        public string GetTitleText() => _modalTitle.Text;

        public void CloseModal() => _closeModalButton.Click();

        public void SubmitModal() => _submitModalButton.Click();
    }
}
