Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, b As Integer
        a = 1
        b = 1
        txtOutput.Text = a & " " & b
        For i As Integer = 1 To 18
            Dim c As Integer = a + b
            txtOutput.Text &= " " & c
            a = b
            b = c
        Next
    End Sub
End Class
