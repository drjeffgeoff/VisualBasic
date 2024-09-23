Imports System

'Looping with While Loop

Module ExampleFour
    Sub Main()
        Dim number As Integer = 0

        ' While loop
        While number >= 0
            Console.WriteLine("Enter a number (negative to stop):")
            number = Convert.ToInt32(Console.ReadLine())

            If number >= 0 Then
                Console.WriteLine("You entered: " & number)
            End If
        End While

        Console.WriteLine("Loop ended due to negative input.")
        Console.ReadLine()
    End Sub
End Module
