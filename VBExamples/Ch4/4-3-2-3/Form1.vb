Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtOutput.Text = (Val(txtInput.Text) - 32) * (5 / 9)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtOutput.Text = Val(txtInput.Text) * (9 / 5) + 32
    End Sub
End Class
