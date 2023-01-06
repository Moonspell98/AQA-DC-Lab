using DiplomaProject.Common.WebElements;
using OpenQA.Selenium;

namespace DiplomaProject.PageObjects.OrangeHRMModals
{
    public class DeleteEmployeeModal : OrangeHRMBaseModal
    {
        private MyWebElement _cancelButton => new MyWebElement(By.XPath("//div[contains(@class, 'modal-footer')]//button[text()[normalize-space() = 'No, Cancel']]"));
        private MyWebElement _acceptButton => new MyWebElement(By.XPath("//div[contains(@class, 'modal-footer')]//button[text()[normalize-space() = 'Yes, Delete']]"));

        public void AcceptDelete() => _acceptButton.Click();
    }
}
