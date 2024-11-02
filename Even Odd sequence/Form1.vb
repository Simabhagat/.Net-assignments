﻿Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim n As Integer
        Dim even As String = ""
        Dim odd As String = ""

        ' Ensure the value in TextBox1 is a valid integer
        If Integer.TryParse(TextBox1.Text, n) Then
            For i As Integer = 1 To n
                If i Mod 2 = 0 Then
                    even &= i.ToString() & ", "
                Else
                    odd &= i.ToString() & ", "
                End If
            Next
            TextBox2.Text = even.Trim()
            TextBox3.Text = odd.Trim()
        Else
            TextBox2.Clear()
            TextBox3.Clear()
        End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class