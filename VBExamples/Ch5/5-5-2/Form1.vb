Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Spend_Money, Money As Double
        Spend_Money = Val(InputBox("今天買了多少錢？", "百貨公司打折程式"))
        Select Case Spend_Money
            Case 0 To 3000
                Money = Spend_Money * 0.9
                MsgBox("打折後總價為" & Money)
            Case 3001 To 6000
                Money = (Spend_Money - 3000) * 0.8 + 3000 * 0.9
                MsgBox("打折後總價為" & Money)
            Case Is >= 6001
                Money = (Spend_Money - 6000) * 0.7 + 3000 * 0.8 + 3000 * 0.9
                MsgBox("打折後總價為" & Money)
            Case Else
                MsgBox("請輸入正數或零")
        End Select
    End Sub
End Class
