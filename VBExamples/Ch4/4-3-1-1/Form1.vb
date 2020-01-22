Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim grade1, grade2, grade3, sum As Double
        grade1 = Val(TextBox1.Text)
        grade2 = Val(TextBox2.Text)
        grade3 = Val(TextBox3.Text)
        sum = grade1 + grade2 + grade3
        lblOutput.Text = sum / 3
    End Sub
End Class
