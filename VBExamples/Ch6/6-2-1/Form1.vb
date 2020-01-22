Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Sum, i As Integer
        i = 1
        Do While i < 100
            Sum += i        'Sum = Sum + i
            Debug.Print("i=" & i & " Sum=" & Sum)
            i += 2           'i = i + 2
        Loop
        MsgBox("1+3+5+...+99=" & Sum)
    End Sub
End Class
