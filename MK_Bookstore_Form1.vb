Public Class Form1

    '========================================================
    ' MK BOOKSTORE SALES SYSTEM
    ' Visual Basic .NET Windows Forms
    '========================================================

    'Form Load - Dynamically load Book Types
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cmbBookType.Items.Clear()

        cmbBookType.Items.Add("Textbook")
        cmbBookType.Items.Add("Novel")
        cmbBookType.Items.Add("Magazine")

        cmbBookType.SelectedIndex = -1

        txtPrice.ReadOnly = True
        txtTotalCost.ReadOnly = True

        txtPrice.Clear()
        txtQuantity.Clear()
        txtTotalCost.Clear()

    End Sub

    'Book Type ComboBox - Display corresponding price
    Private Sub cmbBookType_SelectedIndexChanged(
        sender As Object,
        e As EventArgs
    ) Handles cmbBookType.SelectedIndexChanged

        Select Case cmbBookType.Text

            Case "Textbook"
                txtPrice.Text = "40000"

            Case "Novel"
                txtPrice.Text = "25000"

            Case "Magazine"
                txtPrice.Text = "10000"

            Case Else
                txtPrice.Clear()

        End Select

    End Sub

    'COMPUTE SALES Button
    Private Sub btnComputeSales_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnComputeSales.Click

        Dim price As Decimal
        Dim quantity As Integer
        Dim totalCost As Decimal

        'Check book type
        If cmbBookType.SelectedIndex = -1 Then
            MessageBox.Show(
                "Please select a book type.",
                "MK Bookstore",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )
            cmbBookType.Focus()
            Exit Sub
        End If

        'Check quantity
        If txtQuantity.Text.Trim() = "" Then
            MessageBox.Show(
                "Please enter the quantity.",
                "MK Bookstore",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )
            txtQuantity.Focus()
            Exit Sub
        End If

        'Validate quantity
        If Not Integer.TryParse(txtQuantity.Text, quantity) Then
            MessageBox.Show(
                "Please enter a valid whole number for quantity.",
                "MK Bookstore",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )
            txtQuantity.Focus()
            txtQuantity.SelectAll()
            Exit Sub
        End If

        If quantity <= 0 Then
            MessageBox.Show(
                "Quantity must be greater than zero.",
                "MK Bookstore",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )
            txtQuantity.Focus()
            txtQuantity.SelectAll()
            Exit Sub
        End If

        'Convert price
        If Not Decimal.TryParse(txtPrice.Text, price) Then
            MessageBox.Show(
                "Invalid price.",
                "MK Bookstore",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )
            Exit Sub
        End If

        'Calculate Total Cost = Price x Quantity
        totalCost = price * quantity

        'Display Total Cost
        txtTotalCost.Text = totalCost.ToString("N0")

    End Sub

    'CLEAR Button
    Private Sub btnClear_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnClear.Click

        cmbBookType.SelectedIndex = -1
        txtPrice.Clear()
        txtQuantity.Clear()
        txtTotalCost.Clear()

        cmbBookType.Focus()

    End Sub

End Class
