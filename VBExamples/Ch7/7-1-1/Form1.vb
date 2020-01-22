Public Class Form1
    Dim Total As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim result As String = "您點了以下餐點:" '點擊Button1兩下進入此程式區塊
        If chk1.Checked Then result &= vbCrLf & chk1.Text
        If chk2.Checked Then result &= vbCrLf & chk2.Text
        If chk3.Checked Then result &= vbCrLf & chk3.Text
        result &= vbCrLf & vbCrLf & lblOutput.Text
        MsgBox(result)
        chk1.Checked = False
        chk2.Checked = False
        chk3.Checked = False
    End Sub
    Private Sub chk1_CheckedChanged(sender As Object, e As EventArgs) Handles chk1.CheckedChanged
        If chk1.Checked Then Total += 80 Else Total -= 80
        lblOutput.Text = "總計" & Total & "元"
    End Sub
    Private Sub chk2_CheckedChanged(sender As Object, e As EventArgs) Handles chk2.CheckedChanged
        If chk2.Checked Then Total += 95 Else Total -= 95
        lblOutput.Text = "總計" & Total & "元"
    End Sub
    Private Sub chk3_CheckedChanged(sender As Object, e As EventArgs) Handles chk3.CheckedChanged
        If chk3.Checked Then Total += 90 Else Total -= 90
        lblOutput.Text = "總計" & Total & "元"
    End Sub
End Class