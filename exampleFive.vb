Imports System

'Select Case Control Structure

Module Example5
    Sub Main()
        Dim dayNumber As Integer

        ' Input day number
        Console.WriteLine("Enter a number (1 to 7) to get the day of the week:")
        dayNumber = Convert.ToInt32(Console.ReadLine())

        ' Select Case structure
        Select Case dayNumber
            Case 1
                Console.WriteLine("Sunday")
            Case 2
                Console.WriteLine("Monday")
            Case 3
                Console.WriteLine("Tuesday")
            Case 4
                Console.WriteLine("Wednesday")
            Case 5
                Console.WriteLine("Thursday")
            Case 6
                Console.WriteLine("Friday")
            Case 7
                Console.WriteLine("Saturday")
            Case Else
                Console.WriteLine("Invalid input!")
        End Select

        Console.ReadLine()
    End Sub
End Module

