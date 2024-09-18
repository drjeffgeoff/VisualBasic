Public Class gradingSystem

    Private Sub btnEvaluate_Click(sender As Object, e As EventArgs) Handles btnEvaluate.Click
        Dim marks As Integer
        
        ' Input validation for marks to ensure numeric input
        If Not Integer.TryParse(txtMarks.Text, marks) Then
            MessageBox.Show("Please enter a valid numeric value for marks.")
            Exit Sub
        End If
        
        ' Check if marks exceed 100
        If marks > 100 Then
            MessageBox.Show("Wrong entry, please re-enter the mark")
            Exit Sub
        End If
        
        ' Using Select Case to determine the grade based on marks
        Select Case marks
            Case 90 To 100
                lblGrade.Text = "Excellent"
            Case 80 To 89
                lblGrade.Text = "Very Good"
            Case 70 To 79
                lblGrade.Text = "Good"
            Case 60 To 69
                lblGrade.Text = "Medium"
            Case 50 To 59
                lblGrade.Text = "Pass"
            Case 0 To 49
                lblGrade.Text = "Fail"
            Case Else
                lblGrade.Text = "Invalid Marks"
        End Select
    End Sub
End Class