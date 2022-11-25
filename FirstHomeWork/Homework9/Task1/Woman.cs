namespace Homework9.Task1
{
    public class Woman : Human
    {
        public Woman() : this("Eva", "Smith")
        {
        }

        public Woman(string firstName, string lastName) : base(firstName, lastName)
        {
        }
    }
}
