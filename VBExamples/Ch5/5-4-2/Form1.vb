Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim money As Double
        money = Val(InputBox("今天買了多少錢？", "百貨公司打折程式"))
        If (money >= 0 And money < 3000) Then
            MsgBox("打折後總價為" & money)
        ElseIf (money >= 3000 And money < 6000) Then
            MsgBox("打折後總價為" & money * 0.9)
        ElseIf (money >= 6000 And money < 10000) Then
            MsgBox("打折後總價為" & money * 0.8)
        ElseIf (money >= 10000) Then
            MsgBox("打折後總價為" & money * 0.7)
        Else
            MsgBox("請輸入正數或零")
        End If
    End Sub
End Class
