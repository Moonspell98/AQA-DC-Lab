using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace Homework10
{
    public class WebTablesTests
    {
        IWebDriver _driver;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl("https://demoqa.com/webtables");
        }

        // Add entry to the grid and verify if it appeared in grid
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

            var notEmptyRows = table.FindElements(By.XPath("//*[@class='rt-tbody']//div[@role = 'row'][not(contains(@class, 'padRow'))]"));
            var addedEntryValues = notEmptyRows.Last().FindElements(By.ClassName("rt-td"));
            Assert.Multiple(() =>
            {
                Assert.AreEqual(fname, addedEntryValues[0].Text);
                Assert.AreEqual(lname, addedEntryValues[1].Text);
                Assert.AreEqual(age.ToString(), addedEntryValues[2].Text);
                Assert.AreEqual(email, addedEntryValues[3].Text);
                Assert.AreEqual(salary.ToString(), addedEntryValues[4].Text);
                Assert.AreEqual(department, addedEntryValues[5].Text);
            });
            foreach (var item in addedEntryValues)
            {
                Console.WriteLine(item.Text);
            }
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            _driver.Quit();
        }
    }
   
}
