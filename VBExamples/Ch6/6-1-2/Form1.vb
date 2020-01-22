Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Factorial As Integer = 1
        Dim N As Integer
        N = Val(InputBox("請輸入一正整數", "計算階層"))
        For i As Integer = 1 To N
            Factorial *= i            'Factorial = Factorial * i
            Debug.Print("i=" & i & " Factorial=" & Factorial)
        Next
        MsgBox(N & "!=" & Factorial)
    End Sub
End Class
