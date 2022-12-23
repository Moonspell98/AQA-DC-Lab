using Homework12.Common.WebElements;
using OpenQA.Selenium;

namespace Homework12.Pages.Modals
{
    public class RegistrationFormModal : BaseModal
    {
        private MyWebElement _firstNameTextBox = new MyWebElement(By.XPath("//*[@id='firstName']"));
        private MyWebElement _lastNameTextBox = new MyWebElement(By.XPath("//*[@id='lastName']"));
        private MyWebElement _emailTextBox = new MyWebElement(By.XPath("//*[@id='userEmail']"));
        private MyWebElement _ageTextBox = new MyWebElement(By.XPath("//*[@id='age']"));
        private MyWebElement _salaryTextBox = new MyWebElement(By.XPath("//*[@id='salary']"));
        private MyWebElement _departmentTextBox = new MyWebElement(By.XPath("//*[@id='department']"));

        public void EnterFirstName(string fname) => _firstNameTextBox.SendKeys(fname);

        public void EnterLastName(string lname) => _lastNameTextBox.SendKeys(lname);
        
        public void EnterEmail(string email) => _emailTextBox.SendKeys(email);
        
        public void EnterAge(string age) => _ageTextBox.SendKeys(age);
        
        public void EnterSalary(string salary) => _salaryTextBox.SendKeys(salary);
        
        public void EnterDepartment(string department) => _departmentTextBox.SendKeys(department);
    }
}
