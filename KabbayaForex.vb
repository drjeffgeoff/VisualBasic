Public Class Form1

    '==========================================================
    ' KABBYA FOREX BUREAU
    ' Currency Converter
    '
    ' Exchange Rates:
    ' 540 UGX = 1 Chinese Yuan
    ' 110 UGX = 1 UAE Dirham
    '==========================================================


    '----------------------------------------------------------
    ' Exchange Rate Constants
    '----------------------------------------------------------

    Const UGX_TO_YUAN_RATE As Decimal = 540D
    Const UGX_TO_DIRHAM_RATE As Decimal = 110D


    '----------------------------------------------------------
    ' FORM LOAD
    '----------------------------------------------------------

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Clear all text boxes when the application starts
        txtUGXYuan.Clear()
        txtChineseYuan.Clear()

        txtYuanUGX.Clear()
        txtUGXFromYuan.Clear()

        txtUGXDirham.Clear()
        txtUaeDirham.Clear()

        txtDirhamUGX.Clear()
        txtUGXFromDirham.Clear()

        'Make output fields read-only
        txtChineseYuan.ReadOnly = True
        txtUGXFromYuan.ReadOnly = True
        txtUaeDirham.ReadOnly = True
        txtUGXFromDirham.ReadOnly = True

        'Set the cursor to the first input field
        txtUGXYuan.Focus()

    End Sub


    '==========================================================
    ' 1. CONVERT UGX TO CHINESE YUAN
    '
    ' Formula:
    ' Chinese Yuan = UGX / 540
    '==========================================================

    Private Sub btnConvertToYuan_Click(
        sender As Object,
        e As EventArgs) Handles btnConvertToYuan.Click

        Dim ugxAmount As Decimal
        Dim yuanAmount As Decimal

        'Check whether the user entered an amount
        If txtUGXYuan.Text.Trim() = "" Then

            MessageBox.Show(
                "Please enter the amount in UGX.",
                "Input Required",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning)

            txtUGXYuan.Focus()
            Exit Sub

        End If


        'Check whether the entered value is a valid number
        If Not Decimal.TryParse(txtUGXYuan.Text, ugxAmount) Then

            MessageBox.Show(
                "Please enter a valid numeric amount.",
                "Invalid Input",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error)

            txtUGXYuan.SelectAll()
            txtUGXYuan.Focus()
            Exit Sub

        End If


        'Check for negative amount
        If ugxAmount < 0 Then

            MessageBox.Show(
                "Amount cannot be negative.",
                "Invalid Amount",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning)

            txtUGXYuan.SelectAll()
            txtUGXYuan.Focus()
            Exit Sub

        End If


        'Perform conversion
        yuanAmount = ugxAmount / UGX_TO_YUAN_RATE


        'Display result
        txtChineseYuan.Text = yuanAmount.ToString("N2")

    End Sub


    '==========================================================
    ' 2. CONVERT CHINESE YUAN TO UGX
    '
    ' Formula:
    ' UGX = Chinese Yuan × 540
    '==========================================================

    Private Sub btnConvertToUGXYuan_Click(
        sender As Object,
        e As EventArgs) Handles btnConvertToUGXYuan.Click

        Dim yuanAmount As Decimal
        Dim ugxAmount As Decimal

        'Check whether amount has been entered
        If txtYuanUGX.Text.Trim() = "" Then

            MessageBox.Show(
                "Please enter the amount in Chinese Yuan.",
                "Input Required",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning)

            txtYuanUGX.Focus()
            Exit Sub

        End If


        'Validate input
        If Not Decimal.TryParse(txtYuanUGX.Text, yuanAmount) Then

            MessageBox.Show(
                "Please enter a valid numeric amount.",
                "Invalid Input",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error)

            txtYuanUGX.SelectAll()
            txtYuanUGX.Focus()
            Exit Sub

        End If


        'Check for negative value
        If yuanAmount < 0 Then

            MessageBox.Show(
                "Amount cannot be negative.",
                "Invalid Amount",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning)

            txtYuanUGX.SelectAll()
            txtYuanUGX.Focus()
            Exit Sub

        End If


        'Perform conversion
        ugxAmount = yuanAmount * UGX_TO_YUAN_RATE


        'Display result
        txtUGXFromYuan.Text = ugxAmount.ToString("N2")

    End Sub


    '==========================================================
    ' 3. CONVERT UGX TO UAE DIRHAM
    '
    ' Formula:
    ' UAE Dirham = UGX / 110
    '==========================================================

    Private Sub btnConvertToDirham_Click(
        sender As Object,
        e As EventArgs) Handles btnConvertToDirham.Click

        Dim ugxAmount As Decimal
        Dim dirhamAmount As Decimal

        'Check whether amount has been entered
        If txtUGXDirham.Text.Trim() = "" Then

            MessageBox.Show(
                "Please enter the amount in UGX.",
                "Input Required",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning)

            txtUGXDirham.Focus()
            Exit Sub

        End If


        'Validate input
        If Not Decimal.TryParse(txtUGXDirham.Text, ugxAmount) Then

            MessageBox.Show(
                "Please enter a valid numeric amount.",
                "Invalid Input",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error)

            txtUGXDirham.SelectAll()
            txtUGXDirham.Focus()
            Exit Sub

        End If


        'Check for negative amount
        If ugxAmount < 0 Then

            MessageBox.Show(
                "Amount cannot be negative.",
                "Invalid Amount",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning)

            txtUGXDirham.SelectAll()
            txtUGXDirham.Focus()
            Exit Sub

        End If


        'Perform conversion
        dirhamAmount = ugxAmount / UGX_TO_DIRHAM_RATE


        'Display result
        txtUaeDirham.Text = dirhamAmount.ToString("N2")

    End Sub


    '==========================================================
    ' 4. CONVERT UAE DIRHAM TO UGX
    '
    ' Formula:
    ' UGX = UAE Dirham × 110
    '==========================================================

    Private Sub btnConvertToUGXDirham_Click(
        sender As Object,
        e As EventArgs) Handles btnConvertToUGXDirham.Click

        Dim dirhamAmount As Decimal
        Dim ugxAmount As Decimal

        'Check whether amount has been entered
        If txtDirhamUGX.Text.Trim() = "" Then

            MessageBox.Show(
                "Please enter the amount in UAE Dirham.",
                "Input Required",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning)

            txtDirhamUGX.Focus()
            Exit Sub

        End If


        'Validate input
        If Not Decimal.TryParse(txtDirhamUGX.Text, dirhamAmount) Then

            MessageBox.Show(
                "Please enter a valid numeric amount.",
                "Invalid Input",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error)

            txtDirhamUGX.SelectAll()
            txtDirhamUGX.Focus()
            Exit Sub

        End If


        'Check for negative value
        If dirhamAmount < 0 Then

            MessageBox.Show(
                "Amount cannot be negative.",
                "Invalid Amount",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning)

            txtDirhamUGX.SelectAll()
            txtDirhamUGX.Focus()
            Exit Sub

        End If


        'Perform conversion
        ugxAmount = dirhamAmount * UGX_TO_DIRHAM_RATE


        'Display result
        txtUGXFromDirham.Text = ugxAmount.ToString("N2")

    End Sub


    '==========================================================
    ' 5. CLEAR BUTTON
    '==========================================================

    Private Sub btnClear_Click(
        sender As Object,
        e As EventArgs) Handles btnClear.Click

        'Clear UGX/Yuan conversion
        txtUGXYuan.Clear()
        txtChineseYuan.Clear()

        'Clear Yuan/UGX conversion
        txtYuanUGX.Clear()
        txtUGXFromYuan.Clear()

        'Clear UGX/Dirham conversion
        txtUGXDirham.Clear()
        txtUaeDirham.Clear()

        'Clear Dirham/UGX conversion
        txtDirhamUGX.Clear()
        txtUGXFromDirham.Clear()

        'Return cursor to first field
        txtUGXYuan.Focus()

    End Sub


    '==========================================================
    ' 6. EXIT BUTTON
    '==========================================================

    Private Sub btnExit_Click(
        sender As Object,
        e As EventArgs) Handles btnExit.Click

        Dim answer As DialogResult

        answer = MessageBox.Show(
            "Are you sure you want to exit Kabbya Forex Bureau?",
            "Exit Application",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question)

        If answer = DialogResult.Yes Then

            Application.Exit()

        End If

    End Sub

End Class
