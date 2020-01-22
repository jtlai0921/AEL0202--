Public Class Form1
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        txtOutput.Text = Val(TextBox1.Text) + Val(TextBox2.Text)
    End Sub

    Private Sub btnSub_Click(sender As Object, e As EventArgs) Handles btnSub.Click
        txtOutput.Text = Val(TextBox1.Text) - Val(TextBox2.Text)
    End Sub
End Class
