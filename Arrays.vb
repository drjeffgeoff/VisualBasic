' Module 7: Arrays and Collections


Dim mark1 As Integer
Dim mark2 As Integer
Dim mark3 As Integer
Dim mark4 As Integer
Dim mark5 As Integer


' Use Array to store marks
Dim marks() As Integer = {75, 80, 90, 85, 95}


Dim marks(4) As Integer
marks(0) = 75
marks(1) = 80
marks(2) = 90
marks(3) = 85
marks(4) = 95

' What is array? An array is a collection of variables of the same type that are referred to by a common name. Each variable in the array is called an element, and each element is accessed by its index number.

Dim marks() As Integer = {75, 80, 90, 85, 95}


' Real World Example: Student Marks
Name:           Marks
John        75
Mary        80
Peter       90
Susan      85
David      95


Dim marks() As Integer = {75, 80, 90, 85, 95}

' An array is a data structure that stores multiple values of the same data type under one variable name.


' Advantages of using an array:

''' 
3. Advantages of Arrays
Arrays are useful because they:
- Store multiple values using one variable.
- Make programs easier to organize.
- Allow data to be processed using loops.
- Reduce repetitive code.
- Make calculations easier.
- Allow quick access to individual elements.

'''
Dim marks() As Integer = {75, 80, 90, 85, 95} ' One dimensional array of integers

For Each mark As Integer In marks
    Console.WriteLine(mark)
Next


' Array Indexing
' The index of an array is the position of an element in the array. The first element of an array has an index of 0, the second element has an index of 1,
' and so on. The last element of an array has an index of n-1,
' where n is the number of elements in the array. For example, if an array has 5 elements, the index of the last element is 4. 

Dim fruits() As String = {"Apple", "Banana", "Cherry", "Date", "Elderberry"}


' Declaring an array of strings
Dim arrayName() As  DataType = {value1, value2, value3, ...}

' Declaring and initializing an array of integers
Dim numbers() As Integer = {1, 2, 3, 4, 5}


' Exercise 1: Declare Strings of cities in Uganda#

Dim cities() As String = {"Kampala", "Entebbe", "Jinja", "Mbarara", "Gulu"}

' How do you access an array element? You can access an array element by using its index number. For example, to access the first element of the fruits array, you would use fruits(0). To access the second element, you would use fruits(1), and so on.

' Modifying an array element: 

Dim cities() As String = {"Kampala", "Entebbe", "Jinja", "Mbarara", "Gulu"}
cities(2) = "Iganga" ' Modifying the third element of the array



' Using a For Loop to iterate through an array:
' Loop through the array using a For loop to display each city in the cities array.

Module
    Sub Main()
        Dim cities() As String = {"Kampala", "Entebbe", "Jinja", "Mbarara", "Gulu"}
        cities(2) = "Iganga" ' Modifying the third element of the array

        For i As Integer = 0 To cities.Length - 1
            Console.WriteLine(cities(i))
        Next
    End Sub
End Module


End Module
' Output:
Kampala
Entebbe
Iganga
Mbarara
Gulu


' Important Array Properties
Property            Purpose
Length              Returns the number of elements in the array.
Rank                Returns the number of dimensions in the array.  
GetLength()            Returns the number of elements in the specified dimension of the array.


' Finite Loop: A loop that has a predetermined number of iterations. It will run for a specific number of times and then stop.
'Infinite Loop: A loop that has no predetermined number of iterations. It will continue to run indefinitely until a specific condition is met or the program is terminated.

' One-dimensional array: An array that has a single row or column of elements. It is also known as a linear array.

'Multidimensional array: An array that has more than one row or column of elements. It can be two-dimensional (like a table) or three-dimensional (like a cube).

' 4 Rows and 4 Columns

' Student Name        |  Test1  |  Test2  |  Test3  |  Test4
Isaac                 |   75    |   80    |   90    |   85
Harriet               |   80    |   85    |   95    |   90
Akampa                |   90    |   95    |   81    |   80
Anxious               |   85    |   90    |   80    |   75

Dim studentMarks(,) As Integer =

{
    {75, 80, 90, 85},
    {80, 85, 95, 90},
    {90, 95, 81, 80},
    {85, 90, 80, 75}
}

Console.WriteLine("Student Marks:")
For i As Integer = 0 To studentMarks.GetLength(0) - 1
    For j As Integer = 0 To studentMarks.GetLength(1) - 1
        Console.Write(studentMarks(i, j) & vbTab)
    Next
    Console.WriteLine()
Next

' Assigning values to a multidimensional array:
' Assignment 1
' Write a An Array Code that returns the 81 marks from the studentMarks array.