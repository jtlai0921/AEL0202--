Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim N As Integer
        Dim isPrime As Boolean = True
        N = Val(InputBox("請輸入一正整數", "質數判斷"))
        For i As Integer = 2 To N - 1
            Debug.Print(N & "Mod" & i & "=" & N Mod i)
            If N Mod i = 0 Then
                isPrime = False
                Exit For
            End If
        Next
        If isPrime And N <> 1 Then
            MsgBox(N & "為質數")
        Else
            MsgBox(N & "不是質數")
        End If
    End Sub
End Class
