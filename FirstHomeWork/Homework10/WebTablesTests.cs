using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Homework10
{
    public class WebTablesTests
    {
        IWebDriver _driver;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
             _driver = new ChromeDriver();
             _driver.Manage().Window.Maximize();
             _driver.Navigate().GoToUrl("https://demoqa.com/webtables");
        }


        [Test]
        public void AddEntryToTable()
        {
            var fname = "John";
            var lname = "Doe";
            var email = "jdoe@email.com";
            var age = 20;
            var salary = 1000;
            var department = "Security";

            var table = _driver.FindElement(By.ClassName("rt-table"));
            var addButton = _driver.FindElement(By.Id("addNewRecordButton"));
            var tableHeaderCells = table.FindElements(By.XPath("//*[@role = 'columnheader']"));

            addButton.Click();
            var firstNameTextBox = _driver.FindElement(By.Id("firstName"));
            var lastNameTextBox = _driver.FindElement(By.Id("lastName"));
            var emailTextBox = _driver.FindElement(By.Id("userEmail"));
            var ageTextBox = _driver.FindElement(By.Id("age"));
            var salaryTextBox = _driver.FindElement(By.Id("salary"));
            var departmentTextBox = _driver.FindElement(By.Id("department"));
            var sumbitButton = _driver.FindElement(By.Id("submit"));

            firstNameTextBox.SendKeys(fname);
            lastNameTextBox.SendKeys(lname);
            emailTextBox.SendKeys(email);
            ageTextBox.SendKeys(age.ToString());
            salaryTextBox.SendKeys(salary.ToString());
            departmentTextBox.SendKeys(department);

            sumbitButton.Submit();
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            _driver.Quit();
        }
    }
   
}
