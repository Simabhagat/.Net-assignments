Imports System

Namespace ConstructorExample

    Public Class Person
        Public Property Name As String
        Public Property Age As Integer

        ' Default constructor
        Public Sub New()
            Name = "Unknown"
            Age = 0
            Console.WriteLine("Default constructor called")
        End Sub

        ' Parameterized constructor
        Public Sub New(name As String, age As Integer)
            Me.Name = name
            Me.Age = age
            Console.WriteLine("Parameterized constructor called")
        End Sub

        Public Sub Display()
            Console.WriteLine($"Name: {Name}, Age: {Age}")
        End Sub
    End Class

    Module Program
        Sub Main()
            ' Using the default constructor
            Dim person1 As New Person()
            person1.Display()

            ' Using the parameterized constructor
            Dim person2 As New Person("Alice", 25)
            person2.Display()
        End Sub
    End Module
End Namespace
