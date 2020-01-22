Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x As Integer
        x = Val(InputBox("請輸入x值"))
        MsgBox(f(x))
    End Sub
    Function f(ByVal x)
        f = x ^ 2
    End Function
End Class
