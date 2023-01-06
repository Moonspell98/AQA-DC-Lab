using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomaProject.Common.WebElements
{
    public class MyToast : MyWebElement
    {
        public MyToast(By by) : base(by)
        {
        }

        public void CloseToast() => WebElement.FindElement(By.XPath(".//*[contains(@class,'toast-close') and @role='button']")).Click();

        public string GetToastTitle() => WebElement.FindElement(By.XPath(".//*[contains(@class,'toast-title')]")).Text;

        public string GetToastMessage() => WebElement.FindElement(By.XPath(".//*[contains(@class,'toast-message')]")).Text;
    }
}
