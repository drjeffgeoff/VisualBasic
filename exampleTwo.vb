Imports System

'Conditional Statement (If...Then...Else)

Module ExampleTwo
    Sub Main()
        Dim number As Integer

        ' Input number
        Console.WriteLine("Enter a number:")
        number = Convert.ToInt32(Console.ReadLine())

        ' Conditional check
        If number > 0 Then
            Console.WriteLine("The number is positive.")
        ElseIf number < 0 Then
            Console.WriteLine("The number is negative.")
        Else
            Console.WriteLine("The number is zero.")
        End If

        Console.ReadLine()
    End Sub
End Module
