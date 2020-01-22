Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtOutput.Text = Val(TextBox1.Text) + Val(TextBox2.Text)
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtOutput.Text = Val(TextBox1.Text) - Val(TextBox2.Text)
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        txtOutput.Text = Val(TextBox1.Text) * Val(TextBox2.Text)
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        txtOutput.Text = Val(TextBox1.Text) / Val(TextBox2.Text)
    End Sub
End Class
