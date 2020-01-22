Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Guess As Integer
        Guess = Val(InputBox("請輸入數字1-1000"))
        Do Until Guess = 666        '666為答案
            If Guess > 666 Then
                MsgBox("猜小一點")  '猜太大了，提示使用者猜小一點
                Guess = Val(InputBox("請輸入數字1-1000"))
            Else
                MsgBox("猜大一點")  '猜太小了，提示使用者猜大一點
                Guess = Val(InputBox("請輸入數字1-1000"))
            End If
        Loop
        MsgBox("恭喜，猜中了")
    End Sub
End Class
