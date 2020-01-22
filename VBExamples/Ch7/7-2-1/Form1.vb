Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton1.Checked Then  '點擊Button1兩下進入此程式區塊
            MsgBox("RadioButton只能選取一項", MsgBoxStyle.Critical)
        ElseIf RadioButton2.Checked Then
            MsgBox("答對了", MsgBoxStyle.Information)
        ElseIf RadioButton3.Checked Then
            MsgBox("Enabled屬性代表是否允許使用者選取", MsgBoxStyle.Critical)
        ElseIf RadioButton4.Checked Then
            MsgBox("Text屬性設定顯示的文字", MsgBoxStyle.Critical)
        End If
    End Sub
End Class
