using System;
using System.Collections;

namespace ArrayListExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an ArrayList
            ArrayList myArrayList = new ArrayList();

            // Adding elements to the ArrayList
            myArrayList.Add(10);           // Integer
            myArrayList.Add("Hello");      // String
            myArrayList.Add(3.14);         // Double
            myArrayList.Add(true);         // Boolean

            // Displaying the ArrayList elements
            Console.WriteLine("Elements in the ArrayList:");
            foreach (var item in myArrayList)
            {
                Console.WriteLine(item);
            }

            // Accessing elements by index
            Console.WriteLine($"\nElement at index 1: {myArrayList[1]}");

            // Inserting an element at a specific index
            myArrayList.Insert(2, "Inserted Item");
            Console.WriteLine("\nArrayList after inserting an item at index 2:");
            foreach (var item in myArrayList)
            {
                Console.WriteLine(item);
            }

            // Removing elements
            myArrayList.Remove(10); // Removes the first occurrence of '10'
            myArrayList.RemoveAt(2); // Removes element at index 2
            Console.WriteLine("\nArrayList after removing some elements:");
            foreach (var item in myArrayList)
            {
                Console.WriteLine(item);
            }

            // Checking if an element exists
            Console.WriteLine($"\nDoes the ArrayList contain 'Hello'? {myArrayList.Contains("Hello")}");

            // Clearing all elements
            myArrayList.Clear();
            Console.WriteLine($"\nNumber of elements after clearing: {myArrayList.Count}");
        }
    }
}
