Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim A() As Integer = {1, 2, 3, 4, 5, 6, 7, 8, 9}
        Dim NumToFind, HighIndex, MidIndex, LowIndex As Integer
        NumToFind = Val(InputBox("請輸入搜尋值"))
        HighIndex = UBound(A)
        LowIndex = LBound(A)
        Dim Found As Boolean = False
        Do Until Found OrElse LowIndex > HighIndex
            MidIndex = (HighIndex + LowIndex) \ 2
            Debug.Print("HighIndex=" & HighIndex & " MidIndex=" & MidIndex &
                   " & LowIndex=" & LowIndex)
            If A(MidIndex) = NumToFind Then
                Found = True
            ElseIf A(MidIndex) > NumToFind Then
                HighIndex = MidIndex - 1
            Else
                LowIndex = MidIndex + 1
            End If
            Debug.Print("Found=" & Found)
        Loop
        If Found Then
            MsgBox("陣列中索引" & MidIndex & "的元素 = " & NumToFind)
        Else
            MsgBox("未找到符合的元素")
        End If
    End Sub
End Class
