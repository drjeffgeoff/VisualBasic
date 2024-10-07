Sub DivideNumbers()
    Try
        Dim num1 As Integer = 10
        Dim num2 As Integer = 0
        Dim result As Integer = num1 / num2
        Console.WriteLine("Result: " & result)
    Catch ex As DivideByZeroException
        Console.WriteLine("Error: Division by zero is not allowed.")
    Finally
        Console.WriteLine("Operation completed.")
    End Try
End Sub
