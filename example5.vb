Sub CounterExample()
    Static count As Integer = 0 ' Static variable
    Dim localCount As Integer = 0 ' Local variable

    count += 1
    localCount += 1

    Console.WriteLine("Static count: " & count)
    Console.WriteLine("Local count: " & localCount)
End Sub

Sub Main()
    CounterExample() ' First call
    CounterExample() ' Second call
    CounterExample() ' Third call
End Sub
