Imports System

'Declaring and Initializing Variables

Module exampleOne
    Sub Main()
        ' Declaring variables
        Dim name As String = "Mwajjuma"
        Dim age As Integer = 30
        Dim salary As Double = 4500.50
        Dim isActive As Boolean = True

        ' Displaying the variables
        Console.WriteLine("Name: " & name)
        Console.WriteLine("Age: " & age)
        Console.WriteLine("Salary: " & salary)
        Console.WriteLine("Active Employee: " & isActive)

        Console.ReadLine() ' To keep the console open
    End Sub
End Module
