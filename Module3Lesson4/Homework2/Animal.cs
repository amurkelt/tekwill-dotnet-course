﻿namespace Homework2
{
    internal class Animal
    {
        public string Name { get; set; }

        public Animal(string name)
        {
            Name = name;
        }

        public virtual void ShowDetails()
        {
            Console.WriteLine($"Name: {Name}");
        }
    }
}