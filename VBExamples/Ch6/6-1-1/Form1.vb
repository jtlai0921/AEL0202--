Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Sum As Integer = 0     'Sum = 0
        For i As Integer = 1 To 10
            Sum += i            'Sum = Sum + i
            Debug.Print("i=" & i & " Sum=" & Sum)
        Next
        MsgBox("1+2+...+10=" & Sum)
    End Sub
End Class
