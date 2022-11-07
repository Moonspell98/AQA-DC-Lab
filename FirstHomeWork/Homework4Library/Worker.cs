namespace Homework4Library
{
    public class Worker
    {
        private string firstName;
        private string lastName;
        private string title;
        private int age;

        public Worker() : this("Undefined", "Undefined")
        {

        }

        public Worker(string firstName, string lastName) : this(firstName, lastName, "Undefined", 18)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public Worker(string firstName, string lastName, string title, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.title = title;
            this.age = age;
        }

        public void ShowWorkerFullName()
        {
            Console.WriteLine(firstName + " " + lastName);
        }
        public void ShowWorkerAge()
        {
            Console.WriteLine(age);
        }
        public void ShowWorkerTitle()
        {
            Console.WriteLine(title);
        }
    }
}