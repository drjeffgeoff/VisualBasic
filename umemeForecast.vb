Public Class umemeForecast    
    Private Sub btnFixedChargesTotal_Click(sender As Object, e As EventArgs) Handles btnFixedChargesTotal.Click
        ' Calculate the Fixed Charges Total
        Dim serviceFee As Decimal = CDec(txtServiceFee.Text)
        Dim vat As Decimal = CDec(txtVAT.Text)
        Dim fixedChargesTotal As Decimal = serviceFee + vat

        ' Display the result in the Fixed Charges Total textbox
        txtFixedChargesTotal.Text = fixedChargesTotal.ToString()
    End Sub
    
    
    Private Sub btnTotalCost_Click(sender As Object, e As EventArgs) Handles btnTotalCost.Click
        ' Calculate the total cost
        Dim unitsPurchased As Decimal = CDec(txtUnitsPurchased.Text)
        Dim unitCost As Decimal = 780
        Dim fixedChargesTotal As Decimal = CDec(txtFixedChargesTotal.Text)
        Dim totalCost As Decimal = (unitsPurchased * unitCost) + fixedChargesTotal

        ' Display the result in the Total Cost textbox
        txtTotalCost.Text = totalCost.ToString()
    End Sub

End Class