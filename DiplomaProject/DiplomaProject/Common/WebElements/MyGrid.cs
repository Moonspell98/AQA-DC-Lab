﻿using DiplomaProject.Data.Constants;
using OpenQA.Selenium;

namespace DiplomaProject.Common.WebElements
{
    public class MyGrid : MyWebElement
    {
        public IWebElement FindRowByColumnValue(string columnName, string value) => FindElement(By.XPath($".//div[contains(@class, 'table-cell')][count(//*[@role='columnheader'][text()='{columnName}']//preceding-sibling::div) + 1]/div[text()='{value}']/ancestor::div[@role='row']"));

        public string GetCellTextByColumn(string searchColumnName, string searchValue, string columnName)
        {
            var row = FindRowByColumnValue(searchColumnName, searchValue);
            var cellText = row.FindElement(By.XPath($".//div[@class='oxd-table-cell oxd-padding-cell'][count(//*[@role='columnheader'][text()='{columnName}']//preceding-sibling::div) + 1]")).Text;

            return cellText;
        }

        public void EditRow(string searchColumnName, string searchValue)
        {
            var row = FindRowByColumnValue(searchColumnName, searchValue);
            var editButton = row.FindElement(By.XPath($".//div[@class='oxd-table-cell oxd-padding-cell'][count(//*[@role='columnheader'][text()='{EmployeeListPageColumns.Actions}']//preceding-sibling::div) + 1]//*[contains(@class,'pencil')]"));
            editButton.Click();
        }

        public void DeleteRow(string searchColumnName, string searchValue)
        {
            var row = FindRowByColumnValue(searchColumnName, searchValue);
            var deleteButton = row.FindElement(By.XPath($".//div[@class='oxd-table-cell oxd-padding-cell'][count(//*[@role='columnheader'][text()='{EmployeeListPageColumns.Actions}']//preceding-sibling::div) + 1]//*[contains(@class,'trash')]"));
            deleteButton.Click();
        }

        public void SelectRow(string searchColumnName, string searchValue)
        {
            var row = FindRowByColumnValue(searchColumnName, searchValue);
            var selectCheckbox = row.FindElement(By.XPath(".//*[contains(@class, 'oxd-checkbox-input')]"));
            selectCheckbox.Click();
        }

        public MyGrid(By by) : base(by)
        {
        }
    }
}