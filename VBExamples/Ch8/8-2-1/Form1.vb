Public Class Form1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Select Case cbxLoction.SelectedItem
            Case "日本"
                Label1.Text = "日本時間:" & Now.AddHours(1)
            Case "德國"
                Label1.Text = "德國時間:" & Now.AddHours(-9)
            Case "舊金山"
                Label1.Text = "舊金山時間:" & Now.AddHours(-16)
            Case "杜拜"
                Label1.Text = "杜拜時間:" & Now.AddHours(-4)
            Case "新加坡"
                Label1.Text = "新加坡時間:" & Now
            Case Else
                Label1.Text = "台灣時間:" & Now
        End Select
    End Sub
End Class
