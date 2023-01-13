using DiplomaProject.Common.WebElements;
using OpenQA.Selenium;

namespace DiplomaProject.PageObjects.OrangeHRMModals
{
    public class OrangeHRMBaseModal
    {
        private MyWebElement _closeButton => new MyWebElement(By.XPath("//button[contains(@class, 'close-button')]"));
        private MyWebElement _modalTitle => new MyWebElement(By.XPath("//*[contains(@class, 'card-title')]"));
        private MyWebElement _modalBody => new MyWebElement(By.XPath("//*[contains(@class, 'card-body')]"));

        public void CloseModal() => _closeButton.Click();

        public string GetTitleText() => _modalTitle.Text;

        public string GetBodyText() => _modalBody.Text;
    }
}
