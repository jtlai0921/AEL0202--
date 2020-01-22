Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim student(,) = {{93001, "John", 89, 90, 77},
                      {93002, "Mary", 76, 95, 97},
                      {93003, "Tony", 88, 71, 68}}
        Dim total_score(2), avg_score(2)

        For i As Integer = 0 To 2
            For j As Integer = 2 To 4
                total_score(i) += student(i, j)
            Next
        Next
        For i As Integer = 0 To 2
            avg_score(i) = Math.Round(total_score(i) / 3, 2)
        Next
        txtOutput.Text = "學號   姓名  數學  國文  英文  總分  平均" & vbCrLf
        For i As Integer = 0 To 2
            For j As Integer = 0 To 4
                txtOutput.Text &= student(i, j) & "   "
            Next
            txtOutput.Text &= total_score(i) & " "
            txtOutput.Text &= avg_score(i) & vbCrLf
        Next
    End Sub
End Class
