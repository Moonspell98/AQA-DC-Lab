using DiplomaProject.Common.WebElements;
using DiplomaProject.Data;
using DiplomaProject.Data.Constants;
using OpenQA.Selenium;

namespace DiplomaProject.PageObjects.OrangeHRM.Elements.PIM
{
    public class EmployeeListPage : PimBasePage
    {
        private MyWebElement _addEmployeeButton => new MyWebElement(By.XPath("//button[text()[normalize-space()='Add']]"));
        // Break XPhath to break test
        private MyWebElement _filterByEmployeeIdTextBox => new MyWebElement(By.XPath($"//*[text()='Employe']/ancestor::div/following-sibling::div/input"));
        private MyWebElement _searchButton => new MyWebElement(By.XPath("//button[@type='submit']"));
        private MyGrid _employeesGrid => new MyGrid(By.XPath("//*[contains(@class, 'employee-list')]"));

        public EmployeeListPage()
        {
            pageUrl = TestSettings.EmployeeListPageUrl;
        }

        public AddEmployeePage ClickOnAddEmployeeButton()
        {
            _addEmployeeButton.Click();
            return GenericPages.AddEmployeePage;
        }

        public string GetCellTextById(string id, string columnName)
        {
            var cellValue = _employeesGrid.GetCellTextByColumn(EmployeeListPageColumns.Id, id, columnName);
            return cellValue;
        }

        public void EditEmployeeById(string id)
        {
            _employeesGrid.EditRow(EmployeeListPageColumns.Id, id);
        }

        public void DeleteEmployeeById(string id)
        {
            _employeesGrid.DeleteRow(EmployeeListPageColumns.Id, id);
        }

        public void SearchById(string id)
        {
            _filterByEmployeeIdTextBox.SendKeys(id);
            _searchButton.Click();
        }
    }
}
