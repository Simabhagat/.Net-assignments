Imports System

Namespace InheritanceExample

    ' Base class
    Public Class Person
        Public Property Name As String

        Public Sub Display()
            Console.WriteLine("Name: " & Name)
        End Sub
    End Class

    ' Derived class (Single Inheritance)
    Public Class Employee
        Inherits Person
        Public Property EmployeeID As Integer

        Public Sub ShowEmployeeDetails()
            Console.WriteLine("Employee ID: " & EmployeeID)
        End Sub
    End Class

    ' Further derived class (Multi-Level Inheritance)
    Public Class Manager
        Inherits Employee
        Public Property Department As String

        Public Sub ShowManagerDetails()
            Console.WriteLine("Department: " & Department)
        End Sub
    End Class

    Module Program
        Sub Main()
            ' Demonstrating Single Inheritance
            Console.WriteLine("Single Inheritance Example:")
            Dim employee As New Employee()
            employee.Name = "Alice"
            employee.EmployeeID = 123
            employee.Display()               ' Method from Person
            employee.ShowEmployeeDetails()    ' Method from Employee

            Console.WriteLine(vbCrLf & "Multi-Level Inheritance Example:")
            ' Demonstrating Multi-Level Inheritance
            Dim manager As New Manager()
            manager.Name = "Bob"
            manager.EmployeeID = 456
            manager.Department = "IT"
            manager.Display()                ' Method from Person
            manager.ShowEmployeeDetails()     ' Method from Employee
            manager.ShowManagerDetails()      ' Method from Manager
        End Sub
    End Module
End Namespace
