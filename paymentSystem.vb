' Code for Button for Login
Public Class paymentSystem
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        ' Check if the username is "Accounts" and password is "pass123"
        If txtUsername.Text = "Accounts" And txtPassword.Text = "pass123" Then
            ' Navigate to the second form (dataform) if successful
            Dim dataForm As New dataform()
            dataForm.Show()
            Me.Hide()  ' Hide the login form
        Else
            ' Display message box for incorrect credentials
            MessageBox.Show("Incorrect username/password")
        End If
    End Sub

End Class


' Code for DataForm
Public Class dataform
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' Input validation for numeric fields
        Dim basicPay As Decimal
        Dim medicalAllowance As Decimal
        If Not Decimal.TryParse(txtBasicPay.Text, basicPay) Or Not Decimal.TryParse(txtMedicalAllowance.Text, medicalAllowance) Then
            MessageBox.Show("Please enter valid numeric values for Basic Pay and Medical Allowance.")
            Exit Sub
        End If

        ' Calculate Gross Pay
        Dim grossPay As Decimal = basicPay + medicalAllowance
        lblGrossPay.Text = "Gross Pay: " & grossPay.ToString("C")

        ' Calculate NSSF (5% of Gross Pay)
        Dim nssfContribution As Decimal = grossPay * 0.05D
        lblNSSF.Text = "NSSF Contribution: " & nssfContribution.ToString("C")

        ' Calculate Net Pay (Gross Pay - NSSF Contribution)
        Dim netPay As Decimal = grossPay - nssfContribution
        lblNetPay.Text = "Net Pay: " & netPay.ToString("C")

        ' Navigate to the third form (reportform) with the calculated data
        Dim reportForm As New reportform(grossPay, netPay)
        reportForm.Show()
        Me.Hide()
    End Sub
End Class


' Code for ReportForm
Public Class reportform
    
    Private grossPay As Decimal
    Private netPay As Decimal

    ' Constructor to pass Gross Pay and Net Pay from the second form
    Public Sub New(ByVal gPay As Decimal, ByVal nPay As Decimal)
        InitializeComponent()
        grossPay = gPay
        netPay = nPay
    End Sub

    Private Sub reportform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblGrossPayReport.Text = "Gross Pay: " & grossPay.ToString("C")
        lblNetPayReport.Text = "Net Pay: " & netPay.ToString("C")
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        ' Navigate back to the dataform
        Dim dataForm As New dataform()
        dataForm.Show()
        Me.Hide()
    End Sub
End Class
