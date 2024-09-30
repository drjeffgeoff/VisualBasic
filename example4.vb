Sub ModifyByVal(ByVal x As Integer)
    x += 10 ' This will not affect the original variable
End Sub

Sub ModifyByRef(ByRef x As Integer)
    x += 10 ' This will modify the original variable
End Sub

Sub Main()
    Dim number As Integer = 20

    ModifyByVal(number)
    Console.WriteLine("After ByVal: " & number) ' Output: 20 (no change)

    ModifyByRef(number)
    Console.WriteLine("After ByRef: " & number) ' Output: 30 (modified)
End Sub
