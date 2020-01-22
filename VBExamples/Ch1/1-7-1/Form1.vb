Public Class Form1
    Private Sub btnSayHello_Click(sender As Object, e As EventArgs) Handles btnSayHello.Click
        TextBox1.Text = "Hello, Jason!"
    End Sub
    Private Sub btnGreet_Click(sender As Object, e As EventArgs) Handles btnGreet.Click
        TextBox1.Text = "Fine, thanks. And you?"
    End Sub
End Class
