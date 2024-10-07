Sub DivisionExample()
    Try
        Console.Write("Enter first number: ")
        Dim num1 As Integer = Convert.ToInt32(Console.ReadLine())
        Console.Write("Enter second number: ")
        Dim num2 As Integer = Convert.ToInt32(Console.ReadLine())

        Dim result As Integer = num1 / num2
        Console.WriteLine("Result: " & result)
    Catch ex As DivideByZeroException
        Console.WriteLine("Error: Division by zero is not allowed.")
    Catch ex As FormatException
        Console.WriteLine("Error: Please enter a valid integer.")
    Finally
        Console.WriteLine("Program complete.")
    End Try
End Sub
