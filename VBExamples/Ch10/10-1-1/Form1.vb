Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim A() As Integer = {45, 23, 34, 55, 12, 67, 37, 89, 44, 28}
        For i As Integer = 8 To 0 Step -1
            For j As Integer = 0 To i
                If A(j) > A(j + 1) Then
                    Dim temp As Integer = A(j)
                    A(j) = A(j + 1)
                    A(j + 1) = temp
                End If
            Next
        Next
        For i As Integer = 0 To 9
            txtOutput.Text &= A(i) & " "
        Next
    End Sub
End Class
