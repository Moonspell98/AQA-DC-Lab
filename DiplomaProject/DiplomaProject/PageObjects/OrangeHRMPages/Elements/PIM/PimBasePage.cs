using DiplomaProject.Common.WebElements;
using OpenQA.Selenium;

namespace DiplomaProject.PageObjects.OrangeHRM.Elements.PIM
{
    public class PimBasePage : OrangeHRMBasePage
    {
        private MyWebElement _employeeListNavigationButton => new MyWebElement(By.XPath("//*[contains(@class, 'nav-tab') and text()='Employee List']"));
        private MyWebElement _addEmployeeNavigationButton => new MyWebElement(By.XPath("//*[contains(@class, 'nav-tab') and text()='Add Employee']"));

        public void NavigateToEmployeeListPage() => _employeeListNavigationButton.Click();
        public void NavigateToAddEmployeePage() => _addEmployeeNavigationButton.Click();
    }
}
