Private Sub btnDistribute_Click(sender As Object, e As EventArgs) Handles btnDistribute.Click
    ' Declare variables to hold the amounts
    Dim donationAmount As Double
    Dim socialWorkAmount As Double
    Dim savingsAmount As Double
    Dim welfareAmount As Double

    ' Try...Catch block to handle invalid input (e.g., if the user types letters)
    Try
        ' Convert the entered text to a Double
        donationAmount = Convert.ToDouble(txtDonationAmount.Text)

        ' Calculate the distributions based on the percentages
        socialWorkAmount = donationAmount * 0.28 ' 28%
        savingsAmount = donationAmount * 0.4     ' 40%
        welfareAmount = donationAmount * 0.32    ' 32%

        ' Display the results in the respective textboxes, formatted to 2 decimal places
        txtSocialWork.Text = socialWorkAmount.ToString("F2")
        txtSavings.Text = savingsAmount.ToString("F2")
        txtWelfare.Text = welfareAmount.ToString("F2")

    Catch ex As Exception
        ' Display an error message if the input is not a valid number
        MessageBox.Show("Please enter a valid numeric amount for the donation.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
End Sub


Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
    ' Reset all textboxes using the .Clear() method
    txtDonorName.Clear()
    txtDonationAmount.Clear()
    txtSocialWork.Clear()
    txtSavings.Clear()
    txtWelfare.Clear()
    
    ' Optional: Set the cursor focus back to the first textbox for user convenience
    txtDonorName.Focus()
End Sub











