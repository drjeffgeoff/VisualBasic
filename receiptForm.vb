Public Class receiptForm
    Private Sub ReceiptForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Calculate receipt details
        Dim subtotal As Decimal = DataEntryForm.quantity * DataEntryForm.pricePerItem
        Dim taxRate As Decimal = 0.18D
        Dim totalTax As Decimal = subtotal * taxRate
        Dim totalAmount As Decimal = subtotal + totalTax

        ' Display the receipt in the RichTextBox
        rtxtReceipt.Clear()
        rtxtReceipt.AppendText("China Town Store Uganda" & vbNewLine)
        rtxtReceipt.AppendText("Date of Purchase: " & DataEntryForm.dateOfPurchase.ToShortDateString() & vbNewLine)
        rtxtReceipt.AppendText("Served By: " & DataEntryForm.servedBy & vbNewLine)
        rtxtReceipt.AppendText("----------------------------" & vbNewLine)
        rtxtReceipt.AppendText("Customer Name: " & DataEntryForm.customerName & vbNewLine)
        rtxtReceipt.AppendText("Item: " & DataEntryForm.itemName & vbNewLine)
        rtxtReceipt.AppendText("Quantity: " & DataEntryForm.quantity.ToString() & vbNewLine)
        rtxtReceipt.AppendText("Price per Item: UGX " & DataEntryForm.pricePerItem.ToString("F2") & vbNewLine)
        rtxtReceipt.AppendText("Subtotal: UGX " & subtotal.ToString("F2") & vbNewLine)
        rtxtReceipt.AppendText("Tax (18%): UGX " & totalTax.ToString("F2") & vbNewLine)
        rtxtReceipt.AppendText("Total Amount: UGX " & totalAmount.ToString("F2") & vbNewLine)
        rtxtReceipt.AppendText("----------------------------" & vbNewLine)
        rtxtReceipt.AppendText("Thank you for shopping with us!")
    End Sub

    ' Back button to return to the Data Entry Form
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        ' Show the DataEntryForm
        Dim dataEntryForm As New DataEntryForm
        dataEntryForm.Show()
        ' Close the ReceiptForm
        Me.Close()
    End Sub

    ' Export to PDF functionality
    Private Sub btnExportToPDF_Click(sender As Object, e As EventArgs) Handles btnExportToPDF.Click
        Dim doc As New Document(PageSize.A4)
        Dim pdfFilePath As String = "C:\Receipts\Receipt.pdf"
        PdfWriter.GetInstance(doc, New FileStream(pdfFilePath, FileMode.Create))

        doc.Open()
        doc.Add(New Paragraph(rtxtReceipt.Text))
        doc.Close()

        MessageBox.Show("Receipt exported to PDF successfully!", "Export to PDF", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    ' Print functionality
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Dim printDocument As New PrintDocument()
        AddHandler printDocument.PrintPage, AddressOf Me.PrintPageHandler
        PrintDialog1.Document = printDocument
        If PrintDialog1.ShowDialog() = DialogResult.OK Then
            printDocument.Print()
        End If
    End Sub

    Private Sub PrintPageHandler(sender As Object, e As PrintPageEventArgs)
        e.Graphics.DrawString(rtxtReceipt.Text, New Font("Arial", 12), Brushes.Black, 100, 100)
    End Sub
End Class



