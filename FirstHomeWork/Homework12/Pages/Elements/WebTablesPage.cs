using Homework12.Common.WebElements;
using Homework12.Pages.Modals;
using OpenQA.Selenium;

namespace Homework12.Pages.Elements
{
    public class WebTablesPage
    {
        private MyWebElement _addButton = new MyWebElement(By.XPath("//*[@id='addNewRecordButton']"));
        private MyWebElements _filledRows => new MyWebElements(By.XPath("//*[@class='rt-tbody']//div[@role = 'row'][not(contains(@class, 'padRow'))]"));

        public RegistrationFormModal AddEntry()
        {
            _addButton.Click();

            return new RegistrationFormModal();
        }

        public string GetLastRowCellValue(string columnName) => _filledRows.Last().FindElement(By.XPath($".//div[@class='rt-td'][count(//*[@class='rt-thead -header']//div[text()='{columnName}']/parent::div/preceding-sibling::div) + 1]")).Text;
    }
}
