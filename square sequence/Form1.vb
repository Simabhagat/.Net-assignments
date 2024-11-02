Public Class Form1


    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles labelPrompt.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles textBoxTerms.TextChanged

    End Sub

    Private Sub buttonGenerate_Click_1(sender As Object, e As EventArgs) Handles buttonGenerate.Click
        listBoxSequence.Items.Clear() ' Clear previous items

        Dim terms As Integer
        ' Validate input and generate squares
        If Integer.TryParse(textBoxTerms.Text, terms) AndAlso terms > 0 Then
            For i As Integer = 1 To terms
                Dim square As Integer = i * i
                listBoxSequence.Items.Add(square) ' Add square to ListBox
            Next
        Else
            MessageBox.Show("Please enter a valid positive integer.") ' Show error message
        End If
    End Sub
End Class
