Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, b, c, Check As Integer
        Dim Ans1, Ans2 As Double
        a = Val(TextBox1.Text)
        b = Val(TextBox2.Text)
        c = Val(TextBox3.Text)
        Check = b * b - 4 * a * c
        If Check = 0 Then
            Ans1 = -b / (2 * a)
            txtOutput.Text = "有兩個等根: " & Ans1
        ElseIf Check < 0 Then
            txtOutput.Text = "有兩個虛根"
        Else
            Ans1 = (-b + Math.Sqrt(Check)) / (2 * a)
            Ans2 = (-b - Math.Sqrt(Check)) / (2 * a)
            txtOutput.Text = "有兩個相異的實根: " & Ans1 & " , " & Ans2
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub
End Class
