Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For i As Integer = 1 To 5
            For j As Integer = 1 To i
                txtOutput.Text &= "*"
            Next
            txtOutput.Text &= vbCrLf
        Next
    End Sub
End Class
