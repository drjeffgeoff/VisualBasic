Public Class digitalRecords
    Private Sub btnGenerateSummary_Click(sender As Object, e As EventArgs) Handles btnGenerateSummary.Click
        ' Capture the input values
        Dim invoiceNumber As String = txtInvoiceNumber.Text
        Dim dateInvoice As String = txtDateInvoice.Text
        Dim passenger As String = txtPassenger.Text
        Dim destination As String = txtDestination.Text
        Dim transportCost As String = txtTransportCost.Text

        ' Concatenate the input values into a summary string
        Dim summary As String = "Invoice Number: " & invoiceNumber & vbCrLf &
                                "Date Invoice: " & dateInvoice & vbCrLf &
                                "Passenger: " & passenger & vbCrLf &
                                "Destination: " & destination & vbCrLf &
                                "Transport Cost: " & transportCost

        ' Display the summary in the Summary textbox
        txtSummary.Text = summary
    End Sub
End Class