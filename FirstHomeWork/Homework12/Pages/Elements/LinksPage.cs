using Homework12.Common.WebElements;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework12.Pages.Elements
{
    public class LinksPage
    {
        private MyWebElement _homePageLink = new MyWebElement(By.XPath("//*[@id='simpleLink']"));

        public HomePage ClickOnHomePageLink()
        {
            _homePageLink.Click();

            return new HomePage();
        }
    }
}
