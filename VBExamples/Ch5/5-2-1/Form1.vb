Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim candy, people As Integer
        Dim result As String
        candy = Val(InputBox("請輸入糖果個數"))
        people = Val(InputBox("請輸入人數"))
        result = "每人可分得" & candy \ people & "顆糖果"
        If (candy Mod people) <> 0 Then
            result &= " 其中" & (candy Mod people) & "人可多得1顆"
        End If
        MsgBox(result)
    End Sub
End Class
