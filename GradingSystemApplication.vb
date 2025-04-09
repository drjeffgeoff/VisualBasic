' Grading System Application
' Created for NCIT221-1 Practical Exam
' Student Name: [Your Name]
' Registration Number: [Your Reg No]

Public Class GradingForm
    ' Event handler for Grade button
    Private Sub btnGrade_Click(sender As Object, e As EventArgs) Handles btnGrade.Click
        ' Declare variables
        Dim mark As Double
        Dim gpa As Double
        
        ' Validate input is numeric
        If Not Double.TryParse(txtMark.Text, mark) Then
            MessageBox.Show("Please enter a valid numeric mark", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        
        ' Validate mark is within 0-100 range
        If mark < 0 Or mark > 100 Then
            MessageBox.Show("Mark must be between 0 and 100", "Invalid Range", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        
        ' Determine GPA based on mark range
        If mark >= 80 Then
            gpa = 5.0
        ElseIf mark >= 75 Then
            gpa = 4.5
        ElseIf mark >= 70 Then
            gpa = 4.0
        ElseIf mark >= 65 Then
            gpa = 3.6
        ElseIf mark >= 60 Then
            gpa = 3.0
        ElseIf mark >= 55 Then
            gpa = 2.5
        ElseIf mark >= 50 Then
            gpa = 2.0
        Else
            gpa = 0.0 ' For marks below 50 (fail)
        End If
        
        ' Display the GPA
        lblGPA.Text = "GPA: " & gpa.ToString("0.0")
    End Sub

    ' Event handler for Award button
    Private Sub btnAward_Click(sender As Object, e As EventArgs) Handles btnAward.Click
        ' Declare variables
        Dim mark As Double
        Dim award As String
        
        ' Validate input is numeric
        If Not Double.TryParse(txtMark.Text, mark) Then
            MessageBox.Show("Please enter a valid numeric mark", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        
        ' Validate mark is within 0-100 range
        If mark < 0 Or mark > 100 Then
            MessageBox.Show("Mark must be between 0 and 100", "Invalid Range", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        
        ' Determine degree award based on mark range
        If mark >= 75 Then
            award = "First Class Honors"
        ElseIf mark >= 65 Then
            award = "Second Class Upper"
        ElseIf mark >= 55 Then
            award = "Second Class Lower"
        ElseIf mark >= 50 Then
            award = "Pass Degree"
        Else
            award = "Fail - No Degree Awarded"
        End If
        
        ' Display the award
        lblAward.Text = "Degree Awarded: " & award
    End Sub

    ' Event handler for Reset button
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ' Reset all fields to default values
        txtMark.Text = ""
        lblGPA.Text = "GPA: "
        lblAward.Text = "Degree Awarded: "
        
        ' Set focus back to mark textbox
        txtMark.Focus()
    End Sub
End Class