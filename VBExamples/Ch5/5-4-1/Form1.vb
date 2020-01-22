Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Score As Double
        Score = Val(InputBox("請輸入成績"))
        If (Score >= 90 And Score <= 100) Then
            MsgBox("優等")
        ElseIf (Score >= 80 And Score < 90) Then
            MsgBox("甲等")
        ElseIf (Score >= 70 And Score < 80) Then
            MsgBox("乙等")
        ElseIf (Score >= 60 And Score < 70) Then
            MsgBox("丙等")
        ElseIf (Score >= 0 And Score < 60) Then
            MsgBox("丁等")
        Else
            MsgBox("您輸入的成績有誤喔！")
        End If
    End Sub
End Class
