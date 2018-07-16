Imports System.IO

Public Class Form1
    Public SQL As New SQLControl

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Me.BackColor = Color.FromArgb(0, 31, 96)
        loginbut.BackColor = Color.FromArgb(255, 201, 7)
        loginbut.FlatAppearance.BorderSize = 1

    End Sub

    
    Private Sub loginbut_Click(sender As Object, e As EventArgs) Handles loginbut.Click
        Me.Hide()
        AdminForm.Show()
        'UserForm.Show()
        'Logs.Show()

    End Sub
End Class
