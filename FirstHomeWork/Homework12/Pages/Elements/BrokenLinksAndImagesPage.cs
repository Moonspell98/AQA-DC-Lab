using Homework12.Common.WebElements;
using Homework12.PageObjects;
using OpenQA.Selenium;

namespace Homework12.Pages.Elements
{
    public class BrokenLinksAndImagesPage : BasePage
    {
        private MyWebElements _images = new MyWebElements(By.XPath("//*[@class='row']//img"));

        public bool IsImagesDisplayed()
        {
            var isAnyImageBroken = false;
            foreach (var image in _images)
            {
                if (image.GetAttribute("naturalWidth").Equals("0"))
                {
                    isAnyImageBroken = true;
                }
            }

            return isAnyImageBroken;
        }
    }
}
