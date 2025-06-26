Imports System.Reflection.Emit

Public Class Form1
    Dim alpha As Integer = 255
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.ForeColor = Color.FromArgb(alpha, Label1.ForeColor)
        Timer1.Start()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        alpha -= 10
        If alpha < 0 Then
            alpha = 0
            Timer1.Stop()

        End If
        Label1.ForeColor = Color.FromArgb(alpha, Label1.ForeColor.R, Label1.ForeColor.G, Label1.ForeColor.B)

    End Sub
End Class
