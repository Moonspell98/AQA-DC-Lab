﻿using Homework12.Common.WebElements;
using Homework12.PageObjects;
using OpenQA.Selenium;

namespace Homework12.Pages.Elements
{
    public class CheckBoxPage : BasePage
    {
        private MyWebElement _expandAllButton = new MyWebElement(By.ClassName("rct-icon-expand-all"));
        private MyWebElements _expandedChevrons = new MyWebElements(By.ClassName("rct-icon-expand-open"));
        private MyCheckBox _generalCheckBox = new MyCheckBox(By.ClassName("rct-checkbox"));
        private MyWebElements _allElementsTitles = new MyWebElements(By.ClassName("rct-title"));
        private MyWebElements _allCheckedElements = new MyWebElements(By.ClassName("rct-icon-check"));
        private MyWebElement _resultSection = new MyWebElement(By.Id("result"));

        public void ExpandAll() => _expandAllButton.Click();

        public int ExpandedChevronsCount() => _expandedChevrons.Count();

        public void CheckGeneralCheckBox() => _generalCheckBox.Check();
        
        public List<string> GetAllElementsTitles()
        {
            var titles = new List<string>();
            foreach (var title in _allElementsTitles)
            {
                titles.Add(title.Text);
            }

            return titles;
        }

        public List<string> GetAllCheckedElementsTitles()
        {
            var titles = new List<string>();
            foreach (var title in _allCheckedElements)
            {
                titles.Add(title.Text);
            }

            return titles;
        }

        public string GetResutlSectionText() => _resultSection.Text;
    }
}
