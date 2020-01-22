Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtTemp.Text = TextBox1.Text
        TextBox1.Text = TextBox2.Text
        TextBox2.Text = txtTemp.Text
    End Sub
End Class