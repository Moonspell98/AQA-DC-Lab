using DiplomaProject.Common.WebElements;
using OpenQA.Selenium;

namespace DiplomaProject.PageObjects.OrangeHRMModals
{
    public class DeleteModal : OrangeHRMBaseModal
    {
        private MyWebElement CancelButton => new MyWebElement(By.XPath("//div[contains(@class, 'modal-footer')]//button[text()[normalize-space() = 'No, Cancel']]"));
        private MyWebElement AcceptButton => new MyWebElement(By.XPath("//div[contains(@class, 'modal-footer')]//button[text()[normalize-space() = 'Yes, Delete']]"));

        public void AcceptDelete() => AcceptButton.Click();
    }
}
