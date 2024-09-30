Function AddNumbers(ByVal num1 As Integer, ByVal num2 As Integer) As Integer
    Return num1 + num2
End Function

Sub Main()
    Dim result As Integer = AddNumbers(5, 10) ' Call the function and store the result
    Console.WriteLine("Sum: " & result)
End Sub
