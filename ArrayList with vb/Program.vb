Imports System.Collections

Module Program
    Sub Main()
        ' Create an ArrayList
        Dim myArrayList As New ArrayList()

        ' Adding elements to the ArrayList
        myArrayList.Add(10)        ' Integer
        myArrayList.Add("Hello")   ' String
        myArrayList.Add(3.14)      ' Double
        myArrayList.Add(True)      ' Boolean

        ' Displaying the ArrayList elements
        Console.WriteLine("Elements in the ArrayList:")
        For Each item In myArrayList
            Console.WriteLine(item)
        Next

        ' Accessing elements by index
        Console.WriteLine(vbCrLf & "Element at index 1: " & myArrayList(1))

        ' Inserting an element at a specific index
        myArrayList.Insert(2, "Inserted Item")
        Console.WriteLine(vbCrLf & "ArrayList after inserting an item at index 2:")
        For Each item In myArrayList
            Console.WriteLine(item)
        Next

        ' Removing elements
        myArrayList.Remove(10)      ' Removes the first occurrence of '10'
        myArrayList.RemoveAt(2)     ' Removes element at index 2
        Console.WriteLine(vbCrLf & "ArrayList after removing some elements:")
        For Each item In myArrayList
            Console.WriteLine(item)
        Next

        ' Checking if an element exists
        Console.WriteLine(vbCrLf & "Does the ArrayList contain 'Hello'? " & myArrayList.Contains("Hello"))

        ' Clearing all elements
        myArrayList.Clear()
        Console.WriteLine(vbCrLf & "Number of elements after clearing: " & myArrayList.Count)
    End Sub
End Module
