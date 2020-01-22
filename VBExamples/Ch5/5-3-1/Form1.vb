Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Input As Integer
        Input = MsgBox("降雨機率超過50%了嗎？", vbYesNo)
        If (Input = vbYes) Then
            MsgBox("要帶傘出門")
        Else
            MsgBox("不需帶傘出門")
        End If
    End Sub
End Class
