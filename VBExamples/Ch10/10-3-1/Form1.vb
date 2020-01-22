Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim A() As Integer = {45, 23, 34, 55, 12, 67, 37, 89, 44, 28}
        Dim key As Integer = Val(InputBox("請輸入搜尋值"))
        Dim result As String = "未有符合的元素"
        For i As Integer = 0 To 9
            If A(i) = key Then
                result = "陣列中索引" & i & "的元素 = " & key
                Exit For
            End If
        Next
        MsgBox(result)
    End Sub
End Class
