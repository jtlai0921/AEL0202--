Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim r As Double
        Const pi As Double = 3.14159
        r = Val(InputBox("請輸入半徑", "輸入"))
        MsgBox("圓面積: " & pi * r ^ 2)
        MsgBox("圓周長: " & 2 * pi * r, MsgBoxStyle.Information, "結果二")
    End Sub
End Class
