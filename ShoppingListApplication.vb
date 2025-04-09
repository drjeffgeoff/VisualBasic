' Shopping List Application
' Created for NCIT221-1 Practical Exam
' Student Name: [Your Name]
' Registration Number: [Your Reg No]

Public Class ShoppingListForm

    ' Event handler for Add Item button
    Private Sub btnAddItem_Click(sender As Object, e As EventArgs) Handles btnAddItem.Click
        ' Check if the textbox is not empty
        If txtAddItem.Text <> "" Then
            ' Add the item from textbox to the listbox
            lstShopping.Items.Add(txtAddItem.Text)
            ' Clear the textbox for next entry
            txtAddItem.Text = ""
            ' Set focus back to textbox for convenience
            txtAddItem.Focus()
        Else
            ' Show message if textbox is empty
            MessageBox.Show("Please enter an item to add", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    ' Event handler for Save Shopping List button
    Private Sub btnSaveList_Click(sender As Object, e As EventArgs) Handles btnSaveList.Click
        ' Check if there are items in the listbox
        If lstShopping.Items.Count > 0 Then
            ' Configure the save file dialog
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
            saveFileDialog.Title = "Save Shopping List"
            saveFileDialog.DefaultExt = "txt"
            
            ' Show the save file dialog
            If saveFileDialog.ShowDialog() = DialogResult.OK Then
                Try
                    ' Create a StreamWriter to write to the file
                    Dim writer As New System.IO.StreamWriter(saveFileDialog.FileName)
                    
                    ' Write each item from the listbox to the file
                    For Each item In lstShopping.Items
                        writer.WriteLine(item.ToString())
                    Next
                    
                    ' Close the writer
                    writer.Close()
                    
                    ' Show success message
                    MessageBox.Show("Shopping list saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    ' Show error message if saving fails
                    MessageBox.Show("Error saving file: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        Else
            ' Show message if listbox is empty
            MessageBox.Show("There are no items in the shopping list to save", "Empty List", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
End Class