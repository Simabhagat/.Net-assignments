using System;

namespace ConstructorExample
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        // Default constructor
        public Person()
        {
            Name = "Unknown";
            Age = 0;
            Console.WriteLine("Default constructor called");
        }

        // Parameterized constructor
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
            Console.WriteLine("Parameterized constructor called");
        }

        public void Display()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }

    class Program
    {
        static void Main()
        {
            // Using the default constructor
            Person person1 = new Person();
            person1.Display();

            // Using the parameterized constructor
            Person person2 = new Person("Alice", 25);
            person2.Display();
        }
    }
}
