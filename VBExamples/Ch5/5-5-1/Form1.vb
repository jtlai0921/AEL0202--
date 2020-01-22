Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Input_Month As Integer
        Input_Month = Val(InputBox("現在是幾月？", "月份與季節轉換程式"))
        Select Case Input_Month
            Case 1 To 3
                MsgBox("春季")
            Case 4 To 6
                MsgBox("夏季")
            Case 7 To 9
                MsgBox("秋季")
            Case 10 To 12
                MsgBox("冬季")
            Case Else
                MsgBox("請輸入1-12數字")
        End Select
    End Sub
End Class
