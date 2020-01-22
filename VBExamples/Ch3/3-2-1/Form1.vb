Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        lblOutput.Text = lblOutput.Text & txtName.Text & " "
        txtName.Text = " "
    End Sub
End Class
