Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a(,) As Integer = {{1, 2, 3}, {4, 5, 6}, {7, 8, 9}}
        Dim b(,) As Integer = {{1, 2, 3}, {4, 5, 6}, {7, 8, 9}}
        Dim c(2, 2) As Integer
        For i As Integer = 0 To 2
            For j As Integer = 0 To 2
                c(i, j) = a(i, j) + b(i, j)
            Next
        Next
        For i As Integer = 0 To 2
            For j As Integer = 0 To 2
                txtOutput.Text &= c(i, j) & " "
            Next
            txtOutput.Text &= vbCrLf
        Next
    End Sub
End Class
