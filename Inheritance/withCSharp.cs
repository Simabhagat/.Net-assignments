using System;

namespace InheritanceExample
{
    // Base class
    public class Person
    {
        public string Name { get; set; }

        public void Display()
        {
            Console.WriteLine("Name: " + Name);
        }
    }

    // Derived class (Single Inheritance)
    public class Employee : Person
    {
        public int EmployeeID { get; set; }

        public void ShowEmployeeDetails()
        {
            Console.WriteLine("Employee ID: " + EmployeeID);
        }
    }

    // Further derived class (Multi-Level Inheritance)
    public class Manager : Employee
    {
        public string Department { get; set; }

        public void ShowManagerDetails()
        {
            Console.WriteLine("Department: " + Department);
        }
    }

    class Program
    {
        static void Main()
        {
            // Demonstrating Single Inheritance
            Console.WriteLine("Single Inheritance Example:");
            Employee employee = new Employee();
            employee.Name = "Alice";
            employee.EmployeeID = 123;
            employee.Display();           // Method from Person
            employee.ShowEmployeeDetails(); // Method from Employee

            Console.WriteLine("\nMulti-Level Inheritance Example:");
            // Demonstrating Multi-Level Inheritance
            Manager manager = new Manager();
            manager.Name = "Bob";
            manager.EmployeeID = 456;
            manager.Department = "IT";
            manager.Display();             // Method from Person
            manager.ShowEmployeeDetails(); // Method from Employee
            manager.ShowManagerDetails();  // Method from Manager
        }
    }
}
