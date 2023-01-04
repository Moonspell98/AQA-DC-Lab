using DiplomaProject.Common.WebElements;
using OpenQA.Selenium;

namespace DiplomaProject.PageObjects.OrangeHRM.Elements.PIM
{
    public class EmployeeListPage : PimBasePage
    {
        private MyWebElement _addEmployeeButton => new MyWebElement(By.XPath("//button[text()[normalize-space()='Add']]"));
        private MyWebElement _filterByEmployeeIdTextBox => new MyWebElement(By.XPath("//*[text()='Employee Id']/ancestor::div/following-sibling::div/input"));
        private MyWebElement _searchButton => new MyWebElement(By.XPath("//button[@type='submit']"));
        private MyWebElement _employeesGrid => new MyWebElement(By.XPath("//*[@class='oxd-table orangehrm-employee-list']"));

        public AddEmployeePage ClickOnAddEmployeeButton()
        {
            _addEmployeeButton.Click();
            return GenericPages.AddEmployeePage;
        }

        public MyWebElement FindRowById(string id) => new MyWebElement(By.XPath($".//div[text()='{id}']/ancestor::div[@role='row']")); 

        public string GetCellTextById(string id, string columnName)
        {
            var row = FindRowById(id);
            var cell = row.FindElement(By.XPath($".//div[@class='oxd-table-cell oxd-padding-cell'][count(//*[@role='columnheader'][text()='{columnName}']//preceding-sibling::div) + 1]"));
            return cell.Text;
        }

        public void EditEmployeeById(string id)
        {
            var row = FindRowById(id);
            var editEntryButton = row.FindElement(By.XPath($".//div[@class='oxd-table-cell oxd-padding-cell'][count(//*[@role='columnheader'][text()='Actions']//preceding-sibling::div) + 1]//*[contains(@class,'pencil')]"));
            editEntryButton.Click();
        }

        public void SearchById(string id)
        {
            _filterByEmployeeIdTextBox.SendKeys(id);
            _searchButton.Click();
        }
    }
}
