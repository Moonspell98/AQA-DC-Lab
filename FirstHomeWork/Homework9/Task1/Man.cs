namespace Homework9.Task1
{
    public class Man : Human
    {
        public Man() : this("John", "Doe")
        {
        }

        public Man(string firstName, string lastName) : base(firstName, lastName)
        {
        }
    }
}
