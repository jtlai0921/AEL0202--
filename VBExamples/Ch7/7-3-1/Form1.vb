Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Report1, Report2 As String
        If rbtMale.Checked = True Then
            Report1 = rbtMale.Text
        Else
            Report1 = rbtFemale.Text
        End If
        Report2 = ""
        If chkMusic.Checked Then Report2 &= " " & chkMusic.Text & " "
        If chkMovie.Checked Then Report2 &= " " & chkMovie.Text & " "
        If chkMount.Checked Then Report2 &= " " & chkMount.Text & " "
        If Report2 = "" Then Report2 &= "在家睡覺"
        MsgBox("您為" & Report1 & "，喜歡從事" & Report2 & "活動！",
               MsgBoxStyle.OkCancel, "問卷調查結果")
    End Sub
End Class
