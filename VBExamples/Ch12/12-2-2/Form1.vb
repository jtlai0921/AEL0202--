Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim student(2)
        Dim total_score(2), avg_score(2)
        Dim sr As New IO.StreamReader("D:\DATA\學生成績.txt")

        Dim count As Integer = 1
        While Not sr.EndOfStream
            Dim str = sr.ReadLine
            Dim tmp = Split(str, ", ")
            student(count - 1) = tmp
            For j As Integer = 2 To 4
                total_score(count - 1) += Val(tmp(j))
            Next
            count += 1
        End While

        For i As Integer = 0 To 2
            avg_score(i) = Math.Round(total_score(i) / 3, 2)
        Next
        txtOutput.Text = "學號   姓名  數學  國文  英文  總分  平均" & vbCrLf
        For i As Integer = 0 To 2
            For j As Integer = 0 To 4
                txtOutput.Text &= student(i)(j) & "   "
            Next
            txtOutput.Text &= total_score(i) & "   "
            txtOutput.Text &= avg_score(i) & vbCrLf
        Next

    End Sub
End Class