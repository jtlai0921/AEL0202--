Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Total As Integer
        Select Case lstType.SelectedItem
            Case "頂級悍將" : Total = 30000
            Case "繪圖高手" : Total = 20000
            Case "文書達人" : Total = 10000
            Case Else : MsgBox("請選擇電腦款式", MsgBoxStyle.Information)
        End Select

        For Each item As Object In lstOthers.SelectedItems
            Select Case item
                Case "滑鼠" : Total += 200
                Case "鍵盤" : Total += 300
                Case "麥克風" : Total += 150
                Case "螢幕" : Total += 5000
            End Select
        Next
        MsgBox("合計" & Total & "元")
    End Sub
End Class
