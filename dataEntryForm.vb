Public Class dataEntryForm
    ' Variables to store data
    Public Shared customerName As String
    Public Shared itemName As String
    Public Shared quantity As Integer
    Public Shared pricePerItem As Decimal
    Public Shared servedBy As String
    Public Shared dateOfPurchase As Date

    Private Sub btnGenerateReceipt_Click(sender As Object, e As EventArgs) Handles btnGenerateReceipt.Click
        ' Capture input data
        customerName = txtCustomerName.Text
        itemName = txtItemName.Text
        quantity = Integer.Parse(txtQuantity.Text)
        pricePerItem = Decimal.Parse(txtPricePerItem.Text)
        servedBy = txtServedBy.Text
        dateOfPurchase = dtpDateOfPurchase.Value

        ' Open the Receipt Form to display the generated receipt
        Dim receiptForm As New ReceiptForm
        receiptForm.Show()
        Me.Hide()
    End Sub
End Class
