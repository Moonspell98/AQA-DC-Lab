using DiplomaProject.Common.WebElements;
using OpenQA.Selenium;

namespace DiplomaProject.PageObjects.OrangeHRMModals
{
    public class OrangeHRMBaseModal
    {
        private MyWebElement CloseButton => new MyWebElement(By.XPath("//button[contains(@class, 'close-button')]"));
        private MyWebElement ModalTitle => new MyWebElement(By.XPath("//*[contains(@class, 'card-title')]"));
        private MyWebElement ModalBody => new MyWebElement(By.XPath("//*[contains(@class, 'card-body')]"));

        public void CloseModal() => CloseButton.Click();

        public string GetTitleText() => ModalTitle.Text;

        public string GetBodyText() => ModalBody.Text;
    }
}
