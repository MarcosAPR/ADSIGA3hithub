Public Class Secrearia
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Secrearia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Enabled = False
        Label2.Visible = False


    End Sub
End Class