namespace Homework17.ModelsAdonet
{
    public class User
    {
        public string? Age { get; set; }
        public string? Name { get; set; }
        public int? Id { get; set; }

        public User(string name, string age)
        {
            Name = name;
            Age = age;
        }

        public User() { }
    }
}
