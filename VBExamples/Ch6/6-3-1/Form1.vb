Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, b As Integer
        a = Val(TextBox1.Text)
        b = Val(TextBox2.Text)
        For i As Integer = a To b
            If i Mod 3 <> 0 Then Continue For
            txtOutput.Text &= i & " "
        Next
    End Sub
End Class
