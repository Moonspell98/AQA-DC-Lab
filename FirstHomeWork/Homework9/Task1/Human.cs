﻿namespace Homework9.Task1
{
    public abstract class Human
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        public Human(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
